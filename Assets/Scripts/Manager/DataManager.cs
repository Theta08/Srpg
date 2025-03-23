using System;
using System.Collections.Generic;
using UnityEngine;

public interface ILoader<Key, Value>
{
    Dictionary<Key, Value> MakeDict(); 
}
public class DataManager 
{
    public Dictionary<int, CharacterStat> CharacterStat { get; set; }= new Dictionary<int, CharacterStat>();

    public void Init()
    {
        CharacterStat = LoadJson<CharacterStatLoad, int, CharacterStat>("CharacterStat").MakeDict();

        CharacterStat characterStat = CharacterStat[0];
        //Debug.Log($"hp : {characterStat.hp}  actspd : {characterStat.actspd}");
    }
    
    Loader LoadJson<Loader, Key, Value>(string path) where Loader : ILoader<Key, Value>
    {
        TextAsset textAsset = Managers.Resource.Load<TextAsset>($"Data/{path}");
        return JsonUtility.FromJson<Loader>(textAsset.text);
    }
    
    public T LoadJson<T>(string path)
    {
        TextAsset textAsset = Managers.Resource.Load<TextAsset>($"Data/{path}");
        return JsonUtility.FromJson<T>(textAsset.text);
    }
}
