using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]

public class guntype : ScriptableObject
{
    public float speed;
    public GameObject bullet;

    public void shoot(Transform firePoint)  //instantiation of the bullet
    {
        bullet.GetComponent<bullet>().speed = speed;
        Instantiate(bullet, firePoint.position, firePoint.rotation);


    }

}
