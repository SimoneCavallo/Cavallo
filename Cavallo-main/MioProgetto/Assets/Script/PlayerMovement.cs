using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    RigidBody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<RigidBody2D>{};
    }

    // Update is called once per frame
    void Update()
    {
    Movement();
    }

    void Movement()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(h,v);

        body PlayerPosition(body.position=movement.normalized * Time.deltaTime);
    }
}