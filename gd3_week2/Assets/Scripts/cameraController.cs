using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform player;
    Vector3 cameraOffset;

    
    
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.position + cameraOffset;
    /*
       if(isReverseCam == false) //camera position and rotation are behind the car
            else //camera position and rotation are in front

        if(Input.GetKeyDown(KeyCode.V))
                {
                    if (isReverseCam == false) isReverseCam = true;
                    else isReverseCam == false;
                }

        */
    }

   
}
