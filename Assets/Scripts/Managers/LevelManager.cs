using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class LevelManager : MonoSingleton<LevelManager>
{
    public List<LevelScriptableObject> levels;
    public EnemySpawner enemySpawner;
    void Start()
    {
        levels[ConditionManager.Instance.CheckCondition()].redSlime = (GameObject)Resources.Load("Prefabs/Enemies/"+ "RedSlime", typeof(GameObject) );
        levels[ConditionManager.Instance.CheckCondition()].yellowSlime = (GameObject)Resources.Load("Prefabs/Enemies/"+ "YellowSlime",typeof(GameObject) );
    }

    public LevelScriptableObject GetLevel(){
        return levels[ConditionManager.Instance.CheckCondition()];
    }

}
