using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    float bulletspeed = 70f;

    float bulletlifeline = 2f;

    float time = 0f;

    // Update is called once per frame
    void Update()
    {
      
        Movement();
        Death();
    }

    void Movement()
    {
        transform.position += transform.up * Time.deltaTime * bulletspeed;
    }

    void Death()
    {
        time += Time.deltaTime;
        if (time >= bulletlifeline)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
