using UnityEngine;
using System.Collections;

public class Plot : MonoBehaviour {

	public Rigidbody Door1;
	public Rigidbody Door2;
	public Rigidbody M9;
	public Rigidbody Door3;
	public TextMesh ShowingText;
	string DeathNote ="";
	bool signContract = false;
	bool suicide = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		ShowingText.text = DeathNote;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayHit = new RaycastHit();

		if ( Physics.Raycast ( ray, out rayHit, 8f )&& Input.GetMouseButtonDown (0) ) {

			if ( rayHit.rigidbody == Door1 ) {
				DeathNote = "";
			if (signContract == false) {
				DeathNote += " Would you like to sign a contract with me? \nPress Y/N";
				}else if (signContract == true) {
					DeathNote += " Come on in, I will give you a hearty hospitality.";
				}
			}
			if ( rayHit.rigidbody == Door2 ) {
				DeathNote = "";
				if (signContract == false) {
					DeathNote += " Would you like to sign a contract with me? \nPress Y/N";
				}else if (signContract == true) {
					DeathNote += " Come on in, I will give you a hearty hospitality.";
				}
			}
			if ( rayHit.rigidbody == Door3 ){
				DeathNote ="";
				if (suicide == false && signContract ==true) {
					DeathNote +=" You don't love your wife, do you? You bitch!";
				}else if (suicide == true){
					DeathNote += "Let's begin your journey to the Hell!"; 
				}
			}
			if ( rayHit.rigidbody == M9) {
				DeathNote ="";
				DeathNote +=" It is a M9. Do you dare kill youself to redeem your wife? Press Y/N";
			}
		}

		if (signContract == false && suicide == false) {
			if (Input.GetKeyDown (KeyCode.Y)) {
				DeathNote = "";
				DeathNote += "It's just the beginning.";
				Door1.gameObject.transform.Translate (-2.2f,0,0);
				Door2.gameObject.transform.Translate (+2f,0,0);
				signContract = true;
			}
		}

		if (suicide == false && signContract == true){
			if (Input.GetKeyDown (KeyCode.Y)) {
				DeathNote = "";
				DeathNote += "You are dead already, which is your passport.";
				suicide = true;
			}
		}
	}
}