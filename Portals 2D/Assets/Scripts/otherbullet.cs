using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherbullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;


    // Update is called once per frame
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "Enemy")
        {

            Debug.Log("collided");
            Destroy(hitInfo.gameObject);
        }
    }
}
