using UnityEngine;
using System.Collections;

// Rigidbody-based controller, place it on a Capsule with a Rigidbody (and rotation constraints so it doesn't fall over)
public class RigidbodyController : MonoBehaviour {

	float moveSpeed = 650f;
	float turnSpeed = 60f;

	// Update is called once per frame
	void Update () {
		// turning, does NOT use physics system (torque)
		transform.Rotate ( 0f, Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime, 0f );
	
	}
	
	// all Physics rigidbody calls should be made in FixedUpdate
	void FixedUpdate () {
		// movement forward and backward
		GetComponent<Rigidbody>().AddForce ( transform.forward * Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime );
		// movement sideways
		GetComponent<Rigidbody>().AddForce ( transform.right * Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime );
		

	}
}
