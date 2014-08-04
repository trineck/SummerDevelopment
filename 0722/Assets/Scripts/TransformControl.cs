using UnityEngine;
using System.Collections;

public class TransformControl : MonoBehaviour {


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.W)) {
			GetComponent<Transform> ().position += transform.forward*10;
		} 

	    if(Input.GetKeyDown (KeyCode.S))  {
			GetComponent<Transform> ().position -= transform.forward*10;
	    }
		if(Input.GetKeyDown (KeyCode.A)) {
			transform.Rotate(Vector3.up, -45f, Space.World); 
				
		}
		if(Input.GetKeyDown (KeyCode.D)) {
			transform.Rotate(Vector3.up, 45f, Space.World); 
			
		}
     }
}
