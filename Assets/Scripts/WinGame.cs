using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel("Win");
        }
    }
}
