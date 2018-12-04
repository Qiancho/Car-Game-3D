using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalCar : MonoBehaviour {

    public static int CarType; //1=Silver, 2=Green, 3=Orange
    public string leveltoload;
    public void Silvercar ()
    {
        CarType = 1;

    }

    public void Greencar ()
    {
        CarType = 2;
    }

    public void Orangecar ()
    {
        CarType = 3;
    }
    public void loadlevel(){
        SceneManager.LoadScene(leveltoload);
    }

    public void exitgame(){

        Application.Quit();
    }
}
