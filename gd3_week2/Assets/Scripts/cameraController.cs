using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraOffset, cameraOffsetFP;
    public Vector3 cameraRotation, cameraRotationFP;
    bool isFirstPerson;

    
    
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
       if(isFirstPerson == false) transform.position = player.position + cameraOffset;
       else transform.position = player.position + cameraOffsetFP;

        if (Input.GetKeyDown(KeyCode.V))
                {
                    if (isFirstPerson == false) isFirstPerson = true;
                    else isFirstPerson = false;
                }

    }

   
}
