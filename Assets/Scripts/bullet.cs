using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
	void OntriggerEnter2D(Collider2D col)
	{
		if (col.isTrigger != true) {
			if (col.CompareTag ("Player")) {
				
			}
			Destroy (gameObject);
		}
	}

}