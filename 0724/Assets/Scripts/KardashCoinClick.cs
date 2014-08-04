using UnityEngine;
using System.Collections;

public class KardashCoinClick : MonoBehaviour {

	void OnMouseUpAsButton() {
		transform.localScale *= 2f; // trasnform is shortcut for GetComponent<Trasnform>().
	}
}
