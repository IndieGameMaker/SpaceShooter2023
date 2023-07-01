using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    private int hitCount;
    public GameObject expEffect;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("BULLET"))
        {
            if (++hitCount == 3)
            {
                ExpBarrel();
            }
        }
    }

    void ExpBarrel()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 20000.0f);
        // Explosion Effect
        Instantiate(expEffect, transform.position, Quaternion.identity);
    }
}
