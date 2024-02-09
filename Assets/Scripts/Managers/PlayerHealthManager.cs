using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoSingleton<PlayerHealthManager>
{
    public static PlayerData playerData;

    public void DamageTaken(int damage)
    {
        if (playerData != null) playerData.health -= damage;

        if (playerData.health <= 0) Destroy(GameObject.FindGameObjectWithTag("Player"));

    }
}
