using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	void FixedUpdate ()
	{
	    var force = new Vector3(Input.GetAxis("Vertical"), 0f, -Input.GetAxis("Horizontal"))*20f;
	    GetComponent<Rigidbody>().AddForce(force);
	}
}
