using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeGranade : MonoBehaviour
{
    public float delaySmoke = 3f;

    public GameObject smokeEffect;

    float countdownSmoke;
    bool hasSmokeExploded = false;

    void Start()
    {
        countdownSmoke = delaySmoke;

    }

    void Update()
    {
        countdownSmoke -= Time.deltaTime;
        if (countdownSmoke <= 0f && !hasSmokeExploded)
        {
            SmokeExplode();
            hasSmokeExploded = true;
        }
    }

    void SmokeExplode()
    {
        Debug.Log("SMOKEOUT!");
        Instantiate(smokeEffect, transform.position, transform.rotation);

    }

  
}
