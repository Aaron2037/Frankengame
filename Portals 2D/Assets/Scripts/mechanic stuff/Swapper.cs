using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swapper : MonoBehaviour
{
    public GameObject hill;
    public GameObject pill;
    public GameObject ramp;

    // Start is called before the first frame update
    void Start()
    {
        hill.SetActive(false);
        pill.SetActive(false);
        ramp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            hill.SetActive(true);
            pill.SetActive(false);
            ramp.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            hill.SetActive(false);
            pill.SetActive(true);
            ramp.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            hill.SetActive(false);
            pill.SetActive(false);
            ramp.SetActive(true);
        }
    }
}
