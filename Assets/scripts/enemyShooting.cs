using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{

    public Transform EnemyAim;
    public Transform enemyBullet;

    // Start is called before the first frame update
     void Start()
    {
        StartCoroutine(shootingBulletEnemy());
    }

    void Eshoot()
    {
        Instantiate(enemyBullet, EnemyAim.position, EnemyAim.rotation);
    }

    IEnumerator shootingBulletEnemy()
    {
        float randomDelay = Random.Range(0f, 4f);
        while(true)
        {
            yield return new WaitForSeconds(2 + randomDelay);
            Eshoot();
        }
    }

}

   
