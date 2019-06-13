using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeLauncher : MonoBehaviour {

    public GameObject bulletParent;

    [Header("GrenadeProjectile")]
    public GameObject grenade;
    [Tooltip("Speed of projectiles")]
    public float vSpeed = 20;
    public float hSpeed = 20;
    [SerializeField] private float fireRate;
    public float fireRateMax = 1.0f;

    // Update is called once per frame
    void Update()
    {
        fireRate += Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow) && fireRate > fireRateMax)
        {
            GameObject instantiatedGrenade = Instantiate(grenade.gameObject, transform.position, transform.rotation) as GameObject;
            instantiatedGrenade.transform.parent = bulletParent.transform;
            instantiatedGrenade.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, vSpeed, hSpeed));
            fireRate = 0;
        }
    }
}
