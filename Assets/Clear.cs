﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear : MonoBehaviour {

	[SerializeField] Text ClearText;

	void ClearAppear() {
		ClearText.enabled = true;
	}
}
