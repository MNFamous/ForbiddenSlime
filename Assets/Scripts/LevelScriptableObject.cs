using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

[CreateAssetMenu]
public class LevelScriptableObject : ScriptableObject
{
    void Start(){
        redSlime = (GameObject)Resources.Load("Assets/Prefabs/Enemies/"+ "RedSlime" );
        yellowSlime = (GameObject)Resources.Load("Assets/Prefabs/Enemies/"+ "YellowSlime" );
    }
    //Red Slime
    public GameObject redSlime;
    public int redSlimeCount;
    public float redSlimeInterval;
    public float redSlimeStart;

    //Yellow Slime
    public GameObject yellowSlime;
    public int yellowSlimeCount;
    public float yellowSlimeInterval;
    public float yellowSlimeStart;
}
