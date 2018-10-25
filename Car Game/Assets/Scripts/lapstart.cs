using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lapstart : MonoBehaviour {
    public LapTimeManager lapstart1;
	// Use this for initialization
    void OnTriggerEnter(Collider Col){
        lapstart1.started = true;
    }
}
