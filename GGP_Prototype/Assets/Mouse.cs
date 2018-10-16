﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {
    public float speedH = 10.0f;
    private float yaw = 0.0f;

    private GameObject ship;
	// Use this for initialization
	void Start () {
        ship = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Mouse0))
        {
            yaw += speedH * Input.GetAxis("Mouse X");

            transform.RotateAround(ship.transform.position, Vector3.up, yaw * Time.deltaTime);
        }
    }
}
