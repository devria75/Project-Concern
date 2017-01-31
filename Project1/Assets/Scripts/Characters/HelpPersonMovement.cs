using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class HelpPersonMovement : MonoBehaviour {

    [SerializeField]
    private float speed = 0f;

    private Rigidbody rb;
    	
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if(speed != 0)
            rb.MovePosition(rb.position + transform.forward * speed * Time.deltaTime);
    }

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }

    public float getSpeed()
    {
        return speed;
    }
}
