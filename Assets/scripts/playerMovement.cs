using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float speed;
    Vector3 vec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vec = transform.localPosition;
       if (vec.x > -70 && vec.x < 67)
       {vec.x -= Input.GetAxis("Horizontal") * Time.deltaTime * speed;}
       else if(vec.x <= -70)
       {
        vec.x = -69.9f;
       } else
       {
        vec.x = 66.9f;
       }


        transform.localPosition = vec;

    }
}
