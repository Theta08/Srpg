using System.Collections.Generic;
using UnityEngine;

public class CharacterStatLoad : ILoader<int, CharacterStat>
{
    public List<CharacterStat> CharacterStat = new List<CharacterStat>();

    public Dictionary<int, CharacterStat> MakeDict()
    {
        Dictionary<int, CharacterStat> dic = new Dictionary<int, CharacterStat>();

        foreach (CharacterStat stat in CharacterStat)
        {
            dic.Add(stat.index, stat);
        }

        return dic;
    }
}
