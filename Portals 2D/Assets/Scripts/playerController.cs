using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float pSpeed;
    private Vector2 pVelocity;
    private Rigidbody2D rb2d;
    public guntype slow_bullet;
    public guntype bullet;
    public float timer = 2f;
    public bool switch_type;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        pVelocity = movementInput.normalized * pSpeed;

        timer -= 1f * Time.deltaTime;

        if (timer <= 0)
        {
            if (switch_type)
            {
                bullet.shoot(transform);
                switch_type = !switch_type;
            }
            else
            {
                slow_bullet.shoot(transform);
                switch_type = !switch_type;

            }
            timer = 5f;

        }
    }

    void FixedUpdate() {

        rb2d.MovePosition(rb2d.position + pVelocity * Time.fixedDeltaTime);
    
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        //turret_health turret_Health = collision.GetComponent<turret_health>();
        //if (turret_Health != null)
        //{
        //    turret_Health.TakeDamage(damage);
        //}

        if (col.gameObject.tag == "bullet")
        {
            Debug.Log("collided");
            Destroy(col.gameObject);
        }
    }
}
