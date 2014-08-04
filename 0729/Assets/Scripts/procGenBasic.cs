using UnityEngine;
using System.Collections;

public class procGenBasic : MonoBehaviour {

	public float spawnRadius = 100f;

	public int spawnCount = 100;

	public Transform small, medium, big, tall; //assign in reference in Inspector

	public Transform[] prefabs; //an "array" is a list of things in 1 variale

	// Use this for initialization
	void Start () {

		//spawn 100 things
		int counter = 0;

		while ( counter < spawnCount){ // as long as this expression is ture, it will keep looping

			Transform prefabToSpawn;
			int prefabIndex = Random.Range (0, 4);// possible number is 0, 1, 2, 3 not 4

//			if (prefabIndex == 0) {
//				prefabToSpawn = small;
//			} else if ( prefabIndex == 1 ) {
//				prefabToSpawn = medium;
//			} else if ( prefabIndex == 2) {
//		        prefabToSpawn = big;
//			} else { 
//				prefabToSpawn = tall;
//			}

			prefabToSpawn = prefabs[prefabIndex];

		Instantiate ( prefabToSpawn, 
			             new Vector3(Random.Range (-spawnRadius, spawnRadius), 0f, Random.Range(-spawnRadius,spawnRadius)),
		Quaternion.identity
			);
			counter ++;// add 1 to counter after each loop
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
