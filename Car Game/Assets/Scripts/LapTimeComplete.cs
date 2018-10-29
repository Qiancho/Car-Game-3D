using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeComplete : MonoBehaviour {

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject Min;
    public GameObject Sec;
    public GameObject Mil;

    public GameObject LapTimeBox;

    public GameObject LapCount;
    public int LapsDone;

    void OnTriggerEnter () {
        LapsDone += 1;
        if (LapTimeManager.SecCount <= 9) {
            Sec.GetComponent<Text> ().text = "0" + LapTimeManager.SecCount + ".";
        } else {
            Sec.GetComponent<Text> ().text = "" + LapTimeManager.SecCount + ".";
        }

        if (LapTimeManager.MinCount <= 9) {
            Min.GetComponent<Text> ().text = "0" + LapTimeManager.MinCount + ".";
        } else {
            Min.GetComponent<Text> ().text = "" + LapTimeManager.MinCount + ".";
        }

        Mil.GetComponent<Text> ().text = "" + LapTimeManager.MilCount;

        LapTimeManager.MinCount = 0;
        LapTimeManager.SecCount = 0;
        LapTimeManager.MilCount = 0;
        LapCount.GetComponent<Text> ().text = "" + LapsDone;

        HalfLapTrig.SetActive (true);
        LapCompleteTrig.SetActive (false);
    }
}
