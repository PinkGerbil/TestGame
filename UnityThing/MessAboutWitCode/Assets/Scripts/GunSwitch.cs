using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSwitch : MonoBehaviour
{
    public GameObject playerSimple;
    public GameObject playerShotgun;

    public GameObject currentGun;

    private void Start()
    {
        currentGun = playerSimple;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            switchOffCurrent();
            currentGun = playerSimple;
            currentGun.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            switchOffCurrent();
            currentGun = playerShotgun;
            currentGun.SetActive(true);
        }
    }

    public void switchOffCurrent()
    {
        if (currentGun != null)
        {
            currentGun.SetActive(false);
        }
    }
}
