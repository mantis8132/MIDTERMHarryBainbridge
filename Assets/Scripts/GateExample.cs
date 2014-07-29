using UnityEngine;
using System.Collections;

//PUT THIS SCRIPT ON A "KEY' OBJECT WITH A TRIGGER COLLIDER

public class GateExample : MonoBehaviour {

	//in Unity editor, put the key undergrounrd / out of sight

	public Transform door; //ASSIGN IN UNITY INSPECTOR

	 void OnTriggerEnter () { 

		//DESTROY door because we picked up the key
		Destroy (door.gameObject);

		
		//DESTROY key because we picked it up
		Destroy (gameObject);

	}
}