using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public Transform playerAim;
    public Transform playerBullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shooting();
        }

    }
    void shooting()
    {
        Instantiate(playerBullet, playerAim.position, playerAim.rotation);
    }
}