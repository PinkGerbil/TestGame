using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed; 
    public Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent <Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.TransformDirection(0, 0, 1 * speed);
            //rb.AddForce(0, 0, 1 * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = transform.TransformDirection(0, 0, -1 * speed);
            //rb.AddForce(0, 0, -1 * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = transform.TransformDirection(-1 * speed, 0, 0);
            //rb.AddForce(-1 * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.TransformDirection(1 * speed, 0, 0);
            //rb.AddForce(1 * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Rotate(0, -1, 0);
        }
    }
}
