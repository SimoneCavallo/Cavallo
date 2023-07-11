using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    Transform target;

    float zombieSpeed = 1f;
    float zombieHealth = 100f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
         
        
    }

    // Update is called once per frame
    void Update()
    {
        Following();
      
    }

    void Following()
    {
        Vector2 dir = target.position + transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.position = Vector2.MoveTowards(transform.position, target.position, Time.deltaTime * zombieSpeed);
    }

   void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        damage=20;
        zombieHealth -= damage;

        if (zombieHealth <= 0)
        {
            Destroy(gameObject);
            
        }
    }
     

}
