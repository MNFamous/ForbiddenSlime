using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public LevelScriptableObject level;
    public GameObject SpawnChild;
    public GameObject spawnerPositionObject;
    //Red Slime Condition
    private bool spawnableRed = true;
    private int spawnCountRed;

    //Yellow Slime Condition
    private bool spawnableYellow = true;
    private int spawnCountYellow;

    protected void Start(){
        level = LevelManager.Instance.GetLevel();
        spawnCountRed = level.redSlimeCount;
        spawnCountYellow = level.yellowSlimeCount;
    }

    //Spawning Enemies
    protected void FixedUpdate(){
        if (Time.time > level.redSlimeStart && spawnableRed == true && spawnCountRed > 0 ) StartCoroutine(SpawnEnemyRed());
        if (Time.time > level.yellowSlimeStart && spawnableYellow == true && spawnCountYellow > 0 ) StartCoroutine(SpawnEnemyYellow());
    }

    //Spawn Red Slime
    IEnumerator SpawnEnemyRed(){
        spawnableRed = false;
        yield return new WaitForSeconds(level.redSlimeInterval);
        Debug.LogWarning("SlimeSpawnScriptRed");
        Debug.LogWarning(ConditionManager.Instance.CheckCondition());
        Instantiate(level.redSlime,new Vector3(spawnerPositionObject.transform.position.x,0.4f,spawnerPositionObject.transform.position.z),Quaternion.identity,SpawnChild.transform);
        spawnCountRed--;
        spawnableRed = true;
    }

    //Spawn Yellow Slime
    IEnumerator SpawnEnemyYellow(){
        spawnableYellow = false;
        yield return new WaitForSeconds(level.yellowSlimeInterval);
        Debug.LogWarning("SlimeSpawnScriptYellow");
        Debug.LogWarning(ConditionManager.Instance.CheckCondition());
        Instantiate(level.yellowSlime,new Vector3(spawnerPositionObject.transform.position.x,0.4f,spawnerPositionObject.transform.position.z),Quaternion.identity,SpawnChild.transform);
        spawnCountYellow--;
        spawnableYellow = true;

    }

}
