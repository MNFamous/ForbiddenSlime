using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class RedSlimeController : MonoBehaviour
{
    public SlimeScriptableObject redSlime;
    public GameObject chamber;
    private GameObject _target;
    private Rigidbody _rb;
    [SerializeField]
    private bool _slimeInRange;
    [SerializeField]
    private bool _inChamber;
    [SerializeField]
    private bool _chamberReturn = false;
    private Vector3 _difference;
    private Vector3 _direction;
    private Vector3 _velocity;
    public float followDistance;
    // Update is called once per frame
    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("Slime")) _slimeInRange = true;
    }
    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Slime")) _slimeInRange = false;
        if(other.CompareTag("EnemyChamber")){ 
            _inChamber = false;
            _chamberReturn = false;
            };
    }

    private void Start() {
        _rb = this.gameObject.GetComponent<Rigidbody>();
    }
    private void FixedUpdate() {
        if(_inChamber== false && _chamberReturn == false){
            MoveTowardsChamber(_rb,chamber, redSlime.speed);
        }
    }

    protected void MoveTowardsChamber(Rigidbody entity, GameObject target, float speed)
    {
        Debug.Log("�nside Target mov");
        _difference = target.transform.position - entity.transform.position;
        if ((_difference.x <= followDistance && _difference.x >= -followDistance) && (_difference.z <= followDistance && _difference.z >= -followDistance)){
            _rb.velocity = Vector3.zero;
            _chamberReturn = true;
        };
        _direction = _difference.normalized;
        _velocity = _direction * speed;
        entity.velocity = _velocity;
    }

}*/
