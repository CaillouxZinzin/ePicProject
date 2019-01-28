﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;
    public float speed = 5.0f;
    public float boundY = 1.14f;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        var vel = rb2d.velocity;
        if (Input.GetKey(moveUp))
        {
            vel.y = speed;
        } else if (Input.GetKey(moveDown))
        {
            vel.y = -speed;
        } else if (!Input.anyKey)
        {
            vel.y = 0;
        }
        rb2d.velocity = vel;

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        } else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
	}
}
