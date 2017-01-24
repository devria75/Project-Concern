using UnityEngine;
using System.Collections;

public class StartCrowd : MonoBehaviour {

	public float sensorLength = 5.0f;
	public float speed =10.0f;
	//control where it goes
	public float direction = 1.0f;
	public float turnV = 0.0f;
	public float turnSpeed = 50.0f;
	//public float life = 10f;
	Collider mycol;
	// Use this for initialization
	void Start () {
		mycol = transform.GetComponent<Collider> ();

		//Destroy (gameObject, life);
	}

	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		int flag = 0;
		//right sensor
		if (Physics.Raycast (transform.position, transform.right, out hit, (sensorLength + transform.localScale.x))) {

			if (hit.collider.tag == "Obstacle"  ) {
                turnV -= 1;
                flag++;
            }



			//Also add obstacle tag to ends of the alley
		}

		//left
		if (Physics.Raycast (transform.position, -transform.right, out hit, (sensorLength + transform.localScale.x))) {

            if (hit.collider.tag == "Obstacle"  )
            {

                turnV += 1;
                flag++;
            }

		}

		//front
		if (Physics.Raycast (transform.position, transform.forward, out hit, (sensorLength + transform.localScale.z))) {

            if (hit.collider.tag == "Obstacle"  )
            {
                if (direction == 1.0f)
                {

                    direction = -1;
                }
                flag++;
            }


		}

		//back
		if (Physics.Raycast (transform.position, -transform.forward, out hit, (sensorLength + transform.localScale.z))) {

            if (hit.collider.tag == "Obstacle"  )
            {

                if (direction == -1.0f)
                {

                    direction = 1;
                }
                flag++;
            }

		}

		if(flag == 0){

			turnV = 0;
		}

		transform.Rotate (Vector3.up * (turnSpeed * turnV) * Time.deltaTime);




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
