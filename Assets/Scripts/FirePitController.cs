using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePitController : MonoBehaviour {

	// access flame particle system
	public Transform flames;

	// Use this for initialization
	void Start () {
		// start with flame unkindled
		flames.GetComponent<ParticleSystem> ().Pause();
	}
	
	void OnTriggerEnter(Collider other) 
	{
		// check that tag matches Fire tag of torch flames
		if (other.gameObject.CompareTag ("Fire")) {
			Debug.Log ("fire");
			flames.GetComponent<ParticleSystem> ().Play();
		}
	}
}
