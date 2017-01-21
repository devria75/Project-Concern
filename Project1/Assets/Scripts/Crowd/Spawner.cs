using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject Crowd;
	public float spawnAmountStart = 1f;
	public float spawn = 3f;
	public static int PplHelped; // change this variable when done with counter script
	public Transform[] spawnSpot;
	// Use this for initialization
	void Start () {
	
		InvokeRepeating ("Spawn", spawnAmountStart, spawn);
	}

	void Spawn ()
	{
		// need counter script
		//if (PplHelped >= 5) {

			//spawn = 0.5f;
		//}

		int spawnPointIndex = Random.Range (0, spawnSpot.Length);

		Instantiate (Crowd, spawnSpot[spawnPointIndex].position, spawnSpot[spawnPointIndex].rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
}
