using UnityEngine;
using System.Collections;

public class Ladder : MonoBehaviour {

	bool isPlayerHere = false;
	float moveSpeed = -650;
	float climbSpeed = 200f;
	public Transform climbingthing;

	void OnTriggerEnter ( Collider climbingthing ) {
		isPlayerHere = true;

	}

	void OnTriggerExit ( Collider climbingthing ) {
		isPlayerHere = false;
		
	}

	void Update () {
			if (isPlayerHere == true && Input.GetKeyDown (KeyCode.W)) {

			GetComponent<Rigidbody>().AddForce ( transform.forward * Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime );
			GetComponent<Rigidbody>().AddForce ( Vector3.up * climbSpeed );
			    }
	}

}