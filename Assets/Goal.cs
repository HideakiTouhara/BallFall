using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	[SerializeField] Clear clear;

	void OnTriggerEnter(Collider other) {
		clear.ClearAppear();
	}
}
