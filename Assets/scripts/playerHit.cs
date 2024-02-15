using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("enemyBullet"))
        {Destroy(gameObject);
        EditorApplication.isPlaying = false;
        }
    }
}
