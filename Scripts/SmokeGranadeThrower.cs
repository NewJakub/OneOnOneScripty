using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeGranadeThrower : MonoBehaviour
{
    public float throwForce = 40;
    public GameObject smokeGranadePrefab;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ThrowGranade();
        }


    }

    void ThrowGranade()
    {
        GameObject granade = Instantiate(smokeGranadePrefab, transform.position, transform.rotation);
        Rigidbody rb = granade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }

}