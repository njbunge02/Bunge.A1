using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemyHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("playerBullet"))
        {Destroy(gameObject);
        }
        if (other.CompareTag("FrontWall"))
        {
            EditorApplication.isPlaying = false;
        }
    }
}
