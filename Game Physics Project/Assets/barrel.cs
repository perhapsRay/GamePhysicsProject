using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float move2 = Input.GetAxis("Horizontal2");

        if (move2 < 0)
        {
            transform.Rotate(0, 0, 1);
        }
        if (move2 > 0)
        {
            transform.Rotate(0, 0, -1);
        }
    }
}
