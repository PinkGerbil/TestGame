using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject EnemyInit;
    public GameObject EnemyParent;

    public GameObject Player;

    public float timer; 

    // Use this for initialization
    private void Start ()
    {
	}
	
	// Update is called once per frame
	private void Update ()
    {
        timer += Time.deltaTime;
        if (timer > 2.0f)
        {
            SpawnEnemy();
            timer = 0.0f; 
        }
    }

    private void SpawnEnemy()
    {
        GameObject EnemyI = Instantiate(EnemyInit.gameObject, transform.position, transform.rotation);
        EnemyI.transform.parent = EnemyParent.transform;
    }
}
