using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D bulletRigidbody;

    private void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = transform.forward * speed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            Destroy(gameObject);
            if (player != null)
            {
                player.hit();
            }
        }


        if(collision.gameObject.tag == "BorderBullet")
        {
            Destroy(gameObject);
        }

    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
