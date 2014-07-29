using UnityEngine;
using System.Collections;

public class LookUpandDown : MonoBehaviour {

	float turnSpeed = -60f;

	// Update is called once per frame
	void Update () {
		// turning, does NOT use physics system (torque)
		transform.Rotate ( Input.GetAxis ("Mouse Y") * turnSpeed * Time.deltaTime, 0f, 0f );
		
	}
	
}