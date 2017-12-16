using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePitController : MonoBehaviour {

	// detect if torch flames come into contact with fire pit
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Fire")) {
	


		}

	}
}
