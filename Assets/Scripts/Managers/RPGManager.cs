using System;
using System.IO;
using UnityEngine;

public class RPGManager : MonoSingleton<RPGManager>
{
    public string filePath;

    [SerializeField]
    private string _conditions;
    private void Start()
    {
        filePath = Application.persistentDataPath + "/KeyPoints.json";
    }
    
    public string CreateCondition(){
        _conditions += "{";
        _conditions += "\"condition" + "\"" + ": 0";
        _conditions += "}";
        return _conditions;
    }

    // Write JSON data to a file
    public void WriteToFile(string data)
    {
        if(File.Exists(filePath)){
        File.WriteAllText(filePath, data);
        Debug.Log("JSON data written to: " + filePath); 
        }
        else{
            File.WriteAllText(filePath, CreateCondition());
        }

    }

    // Read JSON data from a file
    public string ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            var data = File.ReadAllText(filePath);
            return data;
        }
        else
        {
            File.WriteAllText(filePath, CreateCondition());
            return null;
        }
    }
}
