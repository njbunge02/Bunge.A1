using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class cameraSwitch : MonoBehaviour
{
    public Camera firstPersonCam;
    public Camera thirdPersonCam;
    public Transform playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        thirdPersonCam.enabled = true;
        firstPersonCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        firstPersonCam.transform.position = new Vector3(playerPosition.position.x, firstPersonCam.transform.position.y, firstPersonCam.transform.position.z);
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(thirdPersonCam.enabled)
            {
                firstPersonCam.enabled = true;
                thirdPersonCam.enabled = false;
            } else
            {
                thirdPersonCam.enabled = true;
                firstPersonCam.enabled = false;
                
            }
        }
    }
}
