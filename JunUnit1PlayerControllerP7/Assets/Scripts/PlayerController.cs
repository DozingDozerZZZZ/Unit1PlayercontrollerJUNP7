using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 2;
    public float horizontalInput = 2;
    public float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
       
        forwardInput = Input.GetAxis("Vertical");

        //Can move the car forward or backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates car based on input
        transform.Rotate(Vector3.up ,turnSpeed * horizontalInput *Time.deltaTime);
    }
}
