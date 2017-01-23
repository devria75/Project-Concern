using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpPerson : MonoBehaviour {

	bool helped;
	public Material[] materials;
	public Renderer rend;
	// Use this for initialization
	void Start () {
		helped = false;
		rend.sharedMaterial = materials [0];
	}

	void OnMouseDown(){
		if (helped == false) {
			rend.sharedMaterial = materials [1];
			helped = true;
		}
	}

    public bool getHelpStatus()
    {
        return helped;
    }

}
