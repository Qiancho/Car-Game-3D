using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LapTimeManager : MonoBehaviour {

    public static int MinCount;
    public static int SecCount;
    public static float MilCount;
    public static string MilDisplay;

    public GameObject Min;
    public GameObject Sec;
    public GameObject Mil;
    public bool started;
    


    void Update () {
        if(started == true){
            MilCount += Time.deltaTime * 10;
            MilDisplay = MilCount.ToString ("F0");
            Mil.GetComponent<Text> ().text = "" + MilDisplay;

            if (MilCount >= 10) {
                MilCount = 0;
                SecCount += 1;
            }

            if (SecCount <= 9) {
                Sec.GetComponent<Text> ().text = "0" + SecCount + ".";
            } else {
                Sec.GetComponent<Text> ().text = "" + SecCount + ".";
            }

            if (SecCount >= 60) {
                SecCount = 0;
                MinCount += 1;
            }

            if (MinCount <= 9) {
                Min.GetComponent<Text> ().text = "0" + MinCount + ":";
            } else {
                Min.GetComponent<Text> ().text = "" + MinCount + ":";
            }
        }
        
        
    }
}

