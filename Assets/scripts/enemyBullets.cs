using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyBullets : MonoBehaviour
{

    public float bulletSpeed = 20f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward * bulletSpeed;
       
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("shield"))
        {
            Destroy(gameObject);
        }
}
}
