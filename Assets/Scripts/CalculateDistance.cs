using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class CalculateDistance : MonoSingleton<CalculateDistance>
{
    public GameObject player;
    public GameObject slime;
    public float distancePlayer;
    public float distanceSlime;

    // Update is called once per frame
    void Update()
    {
        distancePlayer= Vector2.Distance(new Vector2(player.transform.position.x, player.transform.position.z), new Vector2(this.transform.position.x, this.transform.position.z));
        distanceSlime = Vector2.Distance(new Vector2(slime.transform.position.x, slime.transform.position.z), new Vector2(this.transform.position.x, this.transform.position.z));
    }
    private void Start()
    {
       // InvokeRepeating("Test", 1, 1);
    }

    void Test()
    {
        if (distancePlayer > distanceSlime)
        {
            Debug.Log("Slime is more close than player"+ distanceSlime);
        }
        if(distancePlayer < distanceSlime)
        {
            Debug.Log("Player is more close than Slime"+ distancePlayer);
        }
    }
}
