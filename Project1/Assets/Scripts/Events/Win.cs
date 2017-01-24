using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Win : MonoBehaviour {

	public Text winText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player"){
			
			winText.text = "You Win!";
	}
}
}