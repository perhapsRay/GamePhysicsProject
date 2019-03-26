using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        if (move < 0) GetComponent<Rigidbody2D> ().velocity = new Vector3(move * speed, GetComponent<Rigidbody2D>().velocity.y);
        if (move > 0) GetComponent<Rigidbody2D> ().velocity = new Vector3(move * speed, GetComponent<Rigidbody2D>().velocity.y);
    }
}
