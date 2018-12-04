using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {

    //1=Silver, 2=Green, 3=Orange
    public GameObject SilverBody;
    public GameObject GreenBody;
    public GameObject OrangeBody;
    public int CarImport;

    void Start () {
        CarImport = GlobalCar.CarType;
        if (CarImport == 1)
        {
            SilverBody.SetActive(true);
        }

        if (CarImport == 2)
        {
            GreenBody.SetActive(true);
        }
        if (CarImport == 3)
        {
            OrangeBody.SetActive(true);
        }
    }

}
