using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeGranadeDestroy : MonoBehaviour
{
    public float delayDestroySmoke = 10f;

    float countdownDestroySmoke;


    bool hasSmokeDestroyed = false;

    void Start()
    {

        countdownDestroySmoke = delayDestroySmoke;

    }

    void Update()
    {
        
        countdownDestroySmoke -= Time.deltaTime;
        if (countdownDestroySmoke <= 0f && !hasSmokeDestroyed)
        {
            SmokeDestroy();
            hasSmokeDestroyed = true;
        }
    }

    

    void SmokeDestroy()
    {

        Destroy(gameObject);

    }
}
