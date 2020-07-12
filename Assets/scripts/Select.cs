using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// choose level
/// </summary>
public class Select : MonoBehaviour {

    public void BackMenu()
    {
        Application.LoadLevel(1);
    }

    public void Select1()
    {
       
        Application.LoadLevel("Scene/Load_1/Level_1");

    }

    public void Select2()
    {
        Time.timeScale = 1;
        Application.LoadLevel("Scene/Load_2/Level_2");

    }
    public void Select3()
    {
        Time.timeScale = 1;
        Application.LoadLevel("Scene/Load_3/Level_3");

    }
    public void Select4()
    {
        Time.timeScale = 1;
        Application.LoadLevel("Scene/Load_4/Level_4");

    }
    public void Select5()
    {
        Time.timeScale = 1;
        Application.LoadLevel("Scene/Load_5/Level_5");

    }
    public void Select6()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);

    }
    public void Select7()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);

    }
    public void Select8()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);

    }
    public void Select9()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);

    }
    public void Select10()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);

    }


}