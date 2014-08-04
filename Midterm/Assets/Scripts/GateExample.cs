using UnityEngine;
using System.Collections;

public class GateExample : MonoBehaviour {
	public Transform door; //which door? assign in unity inspector
	// Use this for initialization

	//you will need a trigger-collider on thie object
	void OnTriggerEnter (){
				//destroy the door because we picked up the key 
				Destroy (door.gameObject);

				//destroy key because we picked it up
				Destroy (gameObject);
		}
}
