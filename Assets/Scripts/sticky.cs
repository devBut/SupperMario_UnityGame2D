using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticky : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {

        }
    }
}
