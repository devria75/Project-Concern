using UnityEngine;
using System.Collections;

public class MoneyTree : MonoBehaviour {

	public Material[] materials;
	public Renderer rend;
	int resource = 3;
	// Use this for initialization
	void Start () {
		rend.sharedMaterial = materials [3];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		if (resource > 0) {
			FindObjectOfType<playerResources> ().addMoney (4);
			resource -= 1;
			rend.sharedMaterial = materials [resource];
		}
	}
}
