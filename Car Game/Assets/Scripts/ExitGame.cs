using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour {

	void FixedUpdate () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
        Application.Quit();
        }
	}
}

