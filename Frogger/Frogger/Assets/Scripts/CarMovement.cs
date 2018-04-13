﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

	public Rigidbody2D rb;

	public float minSpeed = 8f;
	public float maxSpeed = 12f;

	float speed = 1f;

	void Start ()
	{
		speed = Random.Range (8, 12);
	}

	void FixedUpdate () 
	{
		Vector2 forward = new Vector2 (transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);

	}
}
