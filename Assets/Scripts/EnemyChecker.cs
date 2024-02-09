using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChecker : MonoSingleton<EnemyChecker>
{
    public GameObject enemyContainer;
    public GameObject WinScreen;
    public void CheckEnemy(){
        if (enemyContainer.transform.childCount == 1){
            Debug.LogWarning("Enemies is run out");
            ConditionManager.Instance.ChangeCondition();
            WinScreen.SetActive(true);
        }
        else{
            Debug.LogWarning("There's still enemy " + enemyContainer.transform.childCount);
        }
    }
}
