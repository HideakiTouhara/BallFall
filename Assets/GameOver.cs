using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	[SerializeField] Text GameOverText;

	void OnTriggerEnter(Collider other) {
		GameOverText.enabled = true;
	}
}
