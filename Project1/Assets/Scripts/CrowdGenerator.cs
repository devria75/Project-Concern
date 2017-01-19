using UnityEngine;
using System.Collections;

public class CrowdGenerator : MonoBehaviour {
	
	public float sensorLength = 5.0f;
	public float speed =10.0f;
	//control where it goes
	public float direction = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		if(Physics.Raycast(transform.position, transform.right, out hit(sensorLength + transform.localScale.x)))
		transform.position += transform.forward * (speed*direction) * Time.deltaTime;
		//transform.position += transform.forward * speed * Time.deltaTime;
	
	}

	void OnDrawGizmos(){

		Gizmos.DrawRay (transform.position, transform.forward * (sensorLength + transform.localScale.z));
		Gizmos.DrawRay (transform.position, -transform.forward * (sensorLength + transform.localScale.z));
		Gizmos.DrawRay (transform.position, transform.right * (sensorLength + transform.localScale.x));
		Gizmos.DrawRay (transform.position, -transform.right * (sensorLength + transform.localScale.x));


	}
}
