using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionHealthManager : MonoSingleton<MinionHealthManager>
{
    public SlimeScriptableObject minion;
    [SerializeField]
    private float health;

    private void Start()
    {
        health = minion.health;
    }


    public void GetDamage(float amount, GameObject slime)
    {
        if (health > 0)
        {
            health -= amount;
            Debug.LogWarning(health);
        }
        else if (health == 0)
        {
            Destroy(slime.gameObject);
        }
    }
    public float GetHealth { get { return health; } }

    /*public void GetHeal(int amount) { }*/
}
