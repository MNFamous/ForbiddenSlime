using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class EnemySlimeController : MonoBehaviour
{
    public SlimeScriptableObject Slime;
    public GameObject target;
    public float health;
    private Rigidbody _rb;
    private void Start() {
        health = Slime.health;
        target = GameObject.FindGameObjectWithTag("Player");
        _rb = this.gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        MoveTowards(target);
    }

    //Moving towards to destinated object
    void MoveTowards(GameObject target) {
        //Move torwards the target
        _rb.velocity = (target.transform.position - this.transform.position).normalized * Slime.speed;
        //If too close to the target stop moving
        if (Vector3.Distance(this.transform.position, target.transform.position) < Slime.attackRange) {
            _rb.velocity = Vector3.zero;

            if (target.tag == "Player") {
                //TODO: Add attack to player and wait for intervals
                //Attack(target);
            }
        }
    }

    public void TakeDamage(float damage) {
        health -= damage;
        if (health <= 0) {
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy(){
        EnemyChecker.Instance.CheckEnemy();
    }

}