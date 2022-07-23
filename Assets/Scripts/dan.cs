using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dan : MonoBehaviour {
	public float Speed;
	GameObject Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector3.right * Speed * Time.deltaTime);
		Destroy (this.gameObject, 2f);
		
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag =="Enemy"){
			Scoure.AddScore (10);
			Destroy (this.gameObject);
			Destroy (coll.gameObject);
		}
		if (coll.gameObject.tag == "EnemyFly"){
			Scoure.AddScore (10);
			Destroy (this.gameObject);
			Destroy (coll.gameObject);
		}
	}
}
