using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float rotSpeed; 
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent <Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        getMousePosition();

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
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    rb.transform.Rotate(0, 1 * rotSpeed, 0);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    rb.transform.Rotate(0, -1 * rotSpeed, 0);
        //}
    }

    private void getMousePosition()
    {
        //Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        //Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        //lookPos = lookPos - transform.position;

        //above player pos goes opposite of mouse movement
        //below player pos goes the way the mouse is moving

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward );
        float angle =  AngleBetweenTwoPoints(transform.position, mousePos) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(new Vector3(0f, angle, 0f));
    }

    private float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
