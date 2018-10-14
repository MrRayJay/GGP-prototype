using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projObj : MonoBehaviour {

    public Vector3 dir;
    public float lifeSpan = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        lifeSpan -= (Time.deltaTime * 1);

        if (lifeSpan <= 0)
        {

            Destroy(gameObject);

        }
        else
        {

            transform.Translate(Vector3.forward * Time.deltaTime * 10.0f);

        }

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.name == "asteroid(Clone)")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}
