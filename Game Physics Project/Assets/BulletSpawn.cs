using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour {

    public GameObject bullet;
    public Transform spawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        bool shoot = Input.GetKeyDown(KeyCode.Space);

        if (shoot)
        {
            Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
