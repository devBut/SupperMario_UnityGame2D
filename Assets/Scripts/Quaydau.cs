using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quaydau : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x <= 47)
        {
            Vector3 scale = transform.localScale;
            scale.x = 6;
            transform.localScale = scale;
        }
        else if (transform.position.x > 47)
        {
            Vector3 scale = transform.localScale;
            scale.x = -6;
            transform.localScale = scale;
        }

    
    }
}
