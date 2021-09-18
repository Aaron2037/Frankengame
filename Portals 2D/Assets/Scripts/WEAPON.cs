using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WEAPON : MonoBehaviour
{

    public Transform FIREPOINT;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        Instantiate(bulletPrefab, FIREPOINT.position, FIREPOINT.rotation);
    }
}
