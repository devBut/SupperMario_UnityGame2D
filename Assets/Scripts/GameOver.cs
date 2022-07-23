using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    // Use this for initialization
    public void Startgame()
    {
        Application.LoadLevel("Level1");
    }

    // Update is called once per frame
    public void Exitgame()
    {
        Application.Quit();
    }
}
