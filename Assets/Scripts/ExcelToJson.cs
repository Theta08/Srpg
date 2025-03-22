using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;

public class ExcelToJson :EditorWindow
{
    [SerializeField]
    private string _csvFileName;
    // [SerializeField]
    // private string _jsonFileName;

    [MenuItem("Tools/CSVToJson")]
    public static void RunCsvToJson()
    {
        GetWindow<ExcelToJson>("값 입력 창");
    }
    private void OnGUI()
    {
        GUILayout.Label("값 입력", EditorStyles.boldLabel);
        _csvFileName = EditorGUILayout.TextField("입력할 값:", _csvFileName);
        
        if (GUILayout.Button("실행") && !string.IsNullOrEmpty(_csvFileName))
        {
            RunFunction(_csvFileName);
        }
    }

    private void RunFunction(string value)
    {
        string path = $"Data/CSV/{_csvFileName}";
    
        if (path == "") return;
        
        List<Dictionary<string, object>> dicList = CSVReader.Read(path);
        Dictionary<string, object> dicCsv = new Dictionary<string, object>();
        
        dicCsv.Add($"{_csvFileName}", dicList);
        
        string result = JsonConvert.SerializeObject(dicCsv, Formatting.Indented);
        Debug.Log(result);
      
        if(result.Length > 0)
            SaveJsonFile(result, $"{_csvFileName}.json");
    }
   
    void SaveJsonFile(string json, string name)
    {
        string path = Path.Combine(Application.dataPath + "/Resources/Data", name);
        File.WriteAllText(path, json);
        
        Debug.Log($"JSON 저장완료 : {path}");
        _csvFileName = "";
    }
}
