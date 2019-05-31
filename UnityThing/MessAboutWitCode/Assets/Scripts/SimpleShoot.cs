using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot : MonoBehaviour
{
    public GameObject bulletParent;

    [Header("Bullets")]
    public Rigidbody projectile;
    [Tooltip("Speed of projectiles")]
    public float speed = 20;
    [SerializeField] private float fireRate;
    public float fireRateMax = 0.5f; 

    // Update is called once per frame
    void Update()
    {
        fireRate += Time.deltaTime; 
        if (Input.GetKey(KeyCode.UpArrow) && fireRate > fireRateMax)
        {
            GameObject instantiatedProjectile = Instantiate(projectile.gameObject, transform.position, transform.rotation) as GameObject;
            instantiatedProjectile.transform.parent = bulletParent.transform;
            instantiatedProjectile.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            fireRate = 0; 
        }
    }
}