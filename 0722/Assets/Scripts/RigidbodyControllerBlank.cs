using UnityEngine;
using System.Collections;

public class RigidbodyControllerBlank : MonoBehaviour {

	public float turnSpeed = 30f;
	public float moveSpeed = 50f;
	public float jumpForce = 100f;
	void Update () {
		//turn using horizontal Mouse Movement  does NOT use phisics System (torque)
		transform.Rotate (0f, Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime,0f);

	}

	void FixedUpdate (){
				GetComponent<Rigidbody> ().AddForce (transform.forward * Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime);
				GetComponent<Rigidbody> ().AddForce (transform.right * Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime);
	
				if (Input.GetKeyUp (KeyCode.Space)) {
						GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpForce);
				}
		}
}