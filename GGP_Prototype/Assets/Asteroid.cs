using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.Normalize(new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10))) * speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
