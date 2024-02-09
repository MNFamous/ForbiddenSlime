using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionManager : MonoSingleton<ConditionManager>
{
    // Changing Condition
    public void ChangeCondition()
    {
            string jsonData = RPGManager.Instance.ReadFromFile();
            JSONNode jsonNode = JSON.Parse(jsonData);
            jsonNode["condition"] += 1;
            string data = jsonNode.ToString();
            RPGManager.Instance.WriteToFile(data);
    }
    
    //Checking Condition Number
    public int CheckCondition()
    {
        int result;
        JSONNode jsonNode = JSON.Parse(RPGManager.Instance.ReadFromFile());
        result = jsonNode["condition"];
        return result;
    }


}
