using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class ExcelToJson :MonoBehaviour
{
    
    private void Start()
    {
        Debug.Log("Test");
        // string path = "aa";
        string path = "Data/Test2";

        List<Dictionary<string, object>> testList = CSVReader.Read(path);
       
        string result = JsonConvert.SerializeObject(testList, Formatting.Indented);
        Debug.Log(result);
      
        if(result.Length > 0)
            SaveJsonToFile(result, "JosonTest.json");
    }

    void SaveJsonToFile(string json, string name)
    {
        string path = Path.Combine(Application.dataPath + "/Resources/Data", name);
        File.WriteAllText(path, json);
        
        Debug.Log($"JSON 저장완료 : {path}");
    }
}
