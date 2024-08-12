using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerControls : MonoBehaviour
{
    public float moveSpeed, turnSpeed, reverseSpeed;
    Rigidbody rb;
    float horizontalInput, verticalInput;
    public string playerIndex;

    public float timer;
    int waypointsCrossed;
    bool lapDone;

    public TMP_Text highscoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        //give values to any private variables
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(lapDone == false) timer += Time.deltaTime;

        if (waypointsCrossed >= 4)
        {
            lapDone = true;

            if(timer < PlayerPrefs.GetFloat("Highscore"))
            {
                PlayerPrefs.SetFloat("Highscore", timer);
            }
            
        }

        highscoreText.text = "Highscore : " + PlayerPrefs.GetFloat("Highscore");



        //gets the input from the player
        horizontalInput = Input.GetAxis("Horizontal" + playerIndex);
        verticalInput = Input.GetAxis("Vertical" + playerIndex);

        

        /*
        rb.AddForce(transform.forward * moveSpeed * verticalInput);
        rb.AddTorque(transform.up * turnSpeed * horizontalInput);
        */

        //moves the vehicle according to the inputs
        if(verticalInput > 0) transform.Translate(0, 0, verticalInput * moveSpeed * Time.deltaTime);
        else transform.Translate(0, 0, verticalInput * reverseSpeed * Time.deltaTime);

        

        //turns the vehicle based on player input
        if(verticalInput != 0) transform.Rotate(0, horizontalInput * turnSpeed * Time.deltaTime, 0);


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Waypoint")
        {
            waypointsCrossed++;
        }
    }


}
