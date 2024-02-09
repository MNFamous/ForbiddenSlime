using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public PlayerData playerData;
    public Vector3 rotation;
    public Rigidbody rb;

    void Update() {
        rotation = WorldManager.Instance.worldRotation;
    }
    //Movement input
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;
        Vector3 angle = Quaternion.AngleAxis(rotation.y, Vector3.up) * direction;
        rb.velocity = angle * playerData.speed;

    }
}