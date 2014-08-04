using UnityEngine;
using System.Collections;

public class RaycastDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//construct a ray (an origin and a derection)
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit rayHit = new RaycastHit ();// empty, blank

		//shoot the raycast now
		if (Physics.Raycast (ray, out rayHit, 1000f)
		    && Input.GetMouseButtonDown (1)) {
			Destroy (rayHit.transform.gameObject);
	}
	}
}
