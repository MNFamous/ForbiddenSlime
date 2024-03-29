using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultScript : MonoBehaviour
{
    private GameObject _thisGameObject;

    //Start function adding the object to the Worldmanager list and rotating it according to world orientation.
    void Start(){
        _thisGameObject = gameObject;
        WorldManager.Instance.AddChild(_thisGameObject);
        _thisGameObject.transform.rotation = Quaternion.Euler(WorldManager.Instance.worldRotation);
        Debug.Log("Object Added to the List");
    }
    
    
}
