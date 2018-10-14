using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObj : MonoBehaviour {

    public float speed = 0.0f;
    public GameObject proj;
    public float shotDelay = 0.0f;
    private bool Spacecheck = false;
    private Vector3 curDir;
    private Vector3 prevDir = new Vector3(0,0,0);
    public float mass = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        move();
        shoot();
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        /*
        curDir = new Vector3(0, 0, 0);
        Vector3 change = Vector3.Normalize(Vector3.forward) * speed;

        if (Vector3.Magnitude(curDir) >= 5)
        {

            curDir = Vector3.Normalize(curDir) * 5;

        }
        else if (Vector3.Magnitude(curDir) <= -5) {

            curDir = Vector3.Normalize(curDir) * -5;

        }

        transform.Translate(curDir);

        prevDir = curDir;
        */
    }
    private void move() {

        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(Vector3.up * Time.deltaTime * 100);

        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(Vector3.up * Time.deltaTime * -100);

        }
        if (Input.GetKey(KeyCode.W))
        {

            speed += .3f;

            if (speed >= 5.0f)
            {

                speed = 5.0f;

            }
        }
        if (Input.GetKey(KeyCode.S))
        {

            speed -= .5f;

            if (speed <= -5.0f)
            {

                speed = -5.0f;

            }
        }

    }
    private void shoot() {

        if (Input.GetKey(KeyCode.Space) && Spacecheck == false)
        {
            GameObject projShot = Instantiate(proj, transform.position, Quaternion.identity) as GameObject;
            projShot.transform.rotation = transform.rotation;
            projShot.transform.position = projShot.transform.position + projShot.transform.forward * .7f;
            Spacecheck = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {

            Spacecheck = false;

        }

    }

}
