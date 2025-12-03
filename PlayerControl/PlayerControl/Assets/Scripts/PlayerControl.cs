using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
 
{
    // Start is called before the first frame update
    void Start()
    {
        // Move the vehicle forward
    }

    // Update is called once per frame
    private float speed = 20.0f;
private float horizontalInput;
private float turnSpeed = 45.0f;
private float forwardInput;

    
    void Update() {


        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the car
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
