using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUi : MonoBehaviour {

    public int winLevel;   //current level
    
    public void Load()
    {
        Application.LoadLevel("Scene/Load_1/Level_1");
    }

    //replay
    public void Reaply()
    {
        Time.timeScale = 1;
        Application.LoadLevel(winLevel);
       
    }
    //next level
    public void Next()
    {
        Time.timeScale = 1;
        Application.LoadLevel(winLevel+1);

    }

    //select level
    public void Select()
    {
        Application.LoadLevel("Scene/StartUI/SelectUI");
    }
    //Introduction
    public void Story()
    {
        Application.LoadLevel("Scene/StartUI/Story");
    }
    //back to manual
    public void BackMenu()
    {
        Application.LoadLevel("Scene/StartUI/Ui");
    }
    //quit
    public void Quit()
    {
        Application.Quit();
    }
}
