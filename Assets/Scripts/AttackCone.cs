using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCone : MonoBehaviour {
	public turretAI turretai;
	public bool isLeft = false;

	void awake()
	{
		turretai = gameObject.GetComponentInParent<turretAI> ();
	}


	void OnTriggerStay2D(Collider2D col)
	{
		if (col.CompareTag ("Player")) {
			if (isLeft) {
				turretai.Attack (false);
			}
			else
			{
				turretai.Attack (true);
			}
		}


	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
