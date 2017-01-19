using UnityEngine;
using System.Collections;

public class Weight : MonoBehaviour {
	public float speed = 6f;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	

		int helped = Spawner.PplHelped;

		if (helped <= 5) {

			//add vision affect

			//slow player down
			speed -= 1;
		}
	
	}
		
}
