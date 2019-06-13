using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySeek : MonoBehaviour {

    public GameObject Player;

    public float speedMultiplier = 1.0f;
    public float speed = 10.0f;

    private Rigidbody rb; 

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    private void Update ()
    {
        if (Player.transform.position.x > this.transform.position.x)
        {
            rb.AddForce(speed * speedMultiplier, 0, 0);
            //rb.velocity = transform.TransformDirection(speed * speedMultiplier, 0, 0);
        }
        if (Player.transform.position.x < this.transform.position.x)
        {
            rb.AddForce(-speed * speedMultiplier, 0, 0);
            //rb.velocity = transform.TransformDirection(-speed * speedMultiplier, 0, 0);
        }
        if (Player.transform.position.z > this.transform.position.z)
        {
            rb.AddForce(0, 0, speed * speedMultiplier);
            //rb.velocity = transform.TransformDirection(0, 0, speed * speedMultiplier);
        }
        if (Player.transform.position.z < this.transform.position.z)
        {
            rb.AddForce(0, 0, -speed * speedMultiplier);
            //rb.velocity = transform.TransformDirection(0, 0, -speed * speedMultiplier);
        }
    }    

    //public GameObject SetSeekTarget(GameObject target)
    //{
    //    Player = target;
    //    return Player;
    //}
    
    //public GameObject getSeekTarget()
    //{
    //    return Player;
    //}
}
