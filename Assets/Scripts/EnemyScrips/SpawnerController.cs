using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

    //Rotating parent of spawner point
    public GameObject spawnerCircle;
    public GameObject player;
    public float rotationAmount;
    public float rotationDelay;
    void Start()
    {
        spawnerCircle = this.gameObject;
        InvokeRepeating("RotateCircle",1,rotationDelay);
    }

    void FixedUpdate(){
        this.gameObject.transform.position = new Vector3(player.transform.position.x,this.transform.position.y,player.transform.position.z);
    }
    private void RotateCircle(){
        spawnerCircle.transform.Rotate(0,rotationAmount,0,Space.Self);
    }
    
}
