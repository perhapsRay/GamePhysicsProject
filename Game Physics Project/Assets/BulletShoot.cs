using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour {

    private float force =2000f;
  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print(transform.right * 70);
        if (collision.gameObject.tag == "ShootPoint") GetComponent<Rigidbody2D>().AddForce(transform.right * force);
    }
}
