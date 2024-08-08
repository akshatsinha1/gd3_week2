using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    public float moveSpeed, turnSpeed, reverseSpeed;
    Rigidbody rb;
    float horizontalInput, verticalInput;

    
    // Start is called before the first frame update
    void Start()
    {
        //give values to any private variables
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //gets the input from the player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");




        if (verticalInput > 0) rb.AddForce(transform.forward * moveSpeed * verticalInput);
        else rb.AddForce(transform.forward * reverseSpeed * verticalInput);
        //rb.AddTorque(transform.up * turnSpeed * horizontalInput);


        //moves the vehicle according to the inputs
        //if(verticalInput > 0) transform.Translate(0, 0, verticalInput * moveSpeed * Time.deltaTime);
        //else transform.Translate(0, 0, verticalInput * reverseSpeed * Time.deltaTime);



        //turns the vehicle based on player input
        if (verticalInput != 0) transform.Rotate(0, horizontalInput * turnSpeed * Time.deltaTime, 0);


    }
}
