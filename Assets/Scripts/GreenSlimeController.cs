using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenSlimeController : MonoBehaviour
{
    public SlimeScriptableObject Slime;
    public GameObject target, player, closestEnemy;
    public bool _targetInSight;
    private Rigidbody _rb;

    private bool _attack = true;

    void Start() {
        _rb = this.gameObject.GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        target = player;
    }

    void Update() {
        if (target == null) {
            target = player;
            _targetInSight = false;
        }
    }

    void FixedUpdate() {
        MoveTowards(target);
    }

    void MoveTowards(GameObject target) {
        //Move torwards the target
        _rb.velocity = (target.transform.position - this.transform.position).normalized * Slime.speed;
        //If too close to the target stop moving, if its an enemy attack it
        if (Vector3.Distance(this.transform.position, target.transform.position) < Slime.attackRange) {
            _rb.velocity = Vector3.zero;

            if (target.tag == "Enemy" && _attack == true) {
                Debug.Log("Attack");
                //TODO: Add interval between attacks
                StartCoroutine(AttackCooldown());
            }
        }
    }

    //Cooldown For Attacking
    IEnumerator AttackCooldown(){
        Attack(target);
        _attack = false;
        yield return new WaitForSeconds(Slime.attackInterval);
        _attack = true;
    }

    void Attack(GameObject target) {
        //Attack the target
        target.GetComponent<EnemySlimeController>().TakeDamage(Slime.damage);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy") {
            //Compare the distance between the current closest enemy and the new enemy, set the new target to the closest enemy, if theres no closest enemy set it to the new enemy
            if (closestEnemy == null) {
                closestEnemy = other.gameObject;
            } else if (Vector3.Distance(this.transform.position, other.transform.position) < Vector3.Distance(this.transform.position, closestEnemy.transform.position)) {
                closestEnemy = other.gameObject;
            }  
            target = closestEnemy;
            _targetInSight = true;
        } else if (other.gameObject.tag == "Player" && _targetInSight == false) {
            target = player;
        }
    }

    private void OnTriggerExit(Collider other) {
        //if the trigger that exitted is player, then teleport to the player
        Debug.Log("Trigger Exit");
        if (other.gameObject.tag == "Player") {
            this.transform.position = player.transform.position;
        } else if (other.gameObject.tag == "Enemy") {
            _targetInSight = false;
        }
    }

}