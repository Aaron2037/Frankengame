using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    public guntype slow_bullet;
    public guntype bullet;
    public float timer =2f;
    public bool switch_type;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {    //the timer for the bullets
        timer -= 1f *Time.deltaTime;

        if (timer <=0) {
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


}
