using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpPerson : MonoBehaviour {

	bool helped;
	public Material[] materials;
	public Renderer rend;

    private playerResources resource;
    private HelpPersonMovement movement;
    private SpecialEvent evt;

	// Use this for initialization
	void Start () {
		helped = false;
		rend.sharedMaterial = materials [0];
        movement = GetComponent<HelpPersonMovement>();
        resource = FindObjectOfType<playerResources>();
        evt = GetComponent<SpecialEvent>();
    }

	void Update(){
	}

	void OnMouseDown(){
		if (helped == false && resource.getMoney() > 0 ) {
			resource.subtractMoney (3);
			rend.sharedMaterial = materials [1];
			helped = true;

            if (movement != null)
                movement.enabled = false;

            if (evt != null)
                evt.startCrowdMovement();
		}
	}

    public bool getHelpStatus()
    {
        return helped;
    }
}
