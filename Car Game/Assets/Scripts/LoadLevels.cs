using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour {
    public string leveltoload;
    public bool exit = true;
    public void loadlevel(){
        SceneManager.LoadScene(leveltoload);
    }

    public void exitgame(){

        Application.Quit();
    }
}
