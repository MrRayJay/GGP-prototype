using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popArea : MonoBehaviour {

    public GameObject asteroids;
    public int ammount;

    // Use this for initialization
    void Start () {

        for (int i = 0; i < ammount; i++) {

            GameObject astInst = Instantiate(asteroids, transform.position, Quaternion.identity) as GameObject;
            astInst.transform.position = new Vector3(Random.Range(-20, 20), 1.0f, Random.Range(-20, 20));

        }

	}
	
	// Update is called once per frame
	void Update () {
		

	}
}
