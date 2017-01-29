using UnityEngine;
using System.Collections;

public class CrowdChange : MonoBehaviour {

	//[SerializeField] float Crowdx = 1f;
	//[SerializeField] float Crowdy = 180f;
	//[SerializeField] float Crowdz = 1f;
	//[SerializeField] float turnV = 45f;
	//[SerializeField] float turnSpeed = 50.0f;
	//[SerializeField] float speed =10.0f;
	//control where it goes
	//[SerializeField] float direction = 1.0f;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
		//transform.position += new Vector3(2, 0, 2);
		transform.position += transform.forward;


	
	}

	void OnTriggerEnter (Collider other)
	{
		
		if(other.tag == "Obstacle")
		{
			
			transform.position -= transform.forward;
		
			//transform.Rotate (Vector3.up * (turnSpeed * turnV) * Time.deltaTime);
			transform.Rotate (0, 50, 0);
			//transform.position += new Vector3 (10, 0, 10);

		}

		//if (other.tag == "Player") {

			//other.gameObject.SetActive (false);
		//}
	}
	

}
