using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretAI : MonoBehaviour {
	public int curhealth;
	public int maxhealth;

	public float distance;
	public float wakerange;
	public float shootinterval;
	public float bulletspeed = 100;
	public float bullettime;

	public bool awake = false;
	public bool lookingright = true;

	public GameObject bullet;
	public Transform terget;
 Animator anim;
	public Transform shootpointleft;
	public Transform shootpointright;


	void Awake()
	{
		anim = gameObject.GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start () {
		curhealth = maxhealth;
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("awake", awake);
		anim.SetBool ("lookingright", lookingright);

		RangeCheck ();


		if (terget.transform.position.x > transform.position.x) {
			lookingright = true;
		}

		if (terget.transform.position.x < transform.position.x) {
			lookingright = false;
		}
	}

	void RangeCheck()
	{
		distance = Vector3.Distance (transform.position, terget.transform.position);
		if (distance < wakerange) {
			awake = true;
		}
		if (distance > wakerange) {
			awake = false;
		}
	}

	public void Attack(bool attackingright){
		bullettime += Time.deltaTime;

		if (bullettime >= shootinterval)
		{
			Vector2 direction = terget.transform.position - transform.position;
			direction.Normalize ();

			if (!attackingright) {
				GameObject bulletClone;
				bulletClone = Instantiate (bullet, shootpointleft.transform.position, shootpointleft.transform.rotation) as GameObject;
				bulletClone.GetComponent<Rigidbody2D> ().velocity = direction * bulletspeed;

				bullettime = 0;
			}
			if (attackingright) {
				GameObject bulletClone;
				bulletClone = Instantiate (bullet, shootpointright.transform.position, shootpointright.transform.rotation) as GameObject;
				bulletClone.GetComponent<Rigidbody2D> ().velocity = direction * bulletspeed;

				bullettime = 0;
			}
		}
	}
}
