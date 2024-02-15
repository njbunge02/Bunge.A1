using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullrt : MonoBehaviour
{
    public float bulletSpeed = 20f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward * -1f * bulletSpeed;
       
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }
}
    
}
