using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botton_Game_Object : MonoBehaviour {

    public void Botton_back()
    {
        Application.LoadLevel(0);
    }

    public void Botton_Start()
    {
        Application.LoadLevel(1);
    }

    public void Botton_HOWTOPLAY()
    {
        Application.LoadLevel(2);
    }

    public void Botton_Exit()
    {
        Application.Quit();
    }
}
