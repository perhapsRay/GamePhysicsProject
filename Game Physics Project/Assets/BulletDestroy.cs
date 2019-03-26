using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour {

    public Transform bullet;
    public float collisionRadius = 0.4f;
    public bool collided = false;
    public LayerMask colliderIndicator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

       void FixedUpdate()
    {
        collided = Physics2D.OverlapCircle(bullet.position, collisionRadius, colliderIndicator);

        if (collided)
        {
            Destroy(gameObject);
        }

        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
    }
}
