using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

	public Rigidbody2D rb;

	void FixedUpdate () 
	{
		rb.MovePosition (rb.position + Vector2.right * Time.fixedDeltaTime);

	}
}
