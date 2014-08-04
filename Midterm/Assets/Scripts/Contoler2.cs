using UnityEngine;
using System.Collections;

public class Contoler2 : MonoBehaviour {

	public float turnSpeed = -300f;
	

	void Update () {
		// turning, does NOT use physics system (torque)
		transform.Rotate ( Input.GetAxis ("Mouse Y") * turnSpeed * Time.deltaTime, 0f, 0f );
		
	}
}
