using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Vector2.left*speed, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("ooga");
            //Destroy(collision.gameObject);
        }
    }
}
