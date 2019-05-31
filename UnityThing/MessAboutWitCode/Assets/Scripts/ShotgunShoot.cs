using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunShoot : MonoBehaviour
{
    /*Shotgun Shoot*/
    public GameObject bulletParent;
    public Rigidbody projectile;
    public GameObject[] instantiatedProjectile;

    public float speed = 20;
    public float spread = 1; 

    public float fireRate;
    public float fireRateMax = 0.7f;

    public int bulletCount; 
    private void Update()
    {
        fireRate += Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow) && fireRate > fireRateMax)
        {
            GameObject instantiatedProjectile1 = Instantiate(projectile.gameObject, transform.position, transform.rotation) as GameObject;
            instantiatedProjectile1.transform.parent = bulletParent.transform;
            instantiatedProjectile1.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            
            GameObject instantiatedProjectile2 = Instantiate(projectile.gameObject, transform.position, transform.rotation) as GameObject;
            instantiatedProjectile2.transform.parent = bulletParent.transform;
            instantiatedProjectile2.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(spread, 0, speed));
            
            GameObject instantiatedProjectile3 = Instantiate(projectile.gameObject, transform.position, transform.rotation) as GameObject;
            instantiatedProjectile3.transform.parent = bulletParent.transform;
            instantiatedProjectile3.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(-spread, 0, speed));

            GameObject instantiatedProjectile4 = Instantiate(projectile.gameObject, transform.position, transform.rotation) as GameObject;
            instantiatedProjectile4.transform.parent = bulletParent.transform;
            instantiatedProjectile4.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(spread * 2, 0, speed));

            GameObject instantiatedProjectile5 = Instantiate(projectile.gameObject, transform.position, transform.rotation) as GameObject;
            instantiatedProjectile5.transform.parent = bulletParent.transform;
            instantiatedProjectile5.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(-spread * 2, 0, speed));
            fireRate = 0;
        }
    }
}
