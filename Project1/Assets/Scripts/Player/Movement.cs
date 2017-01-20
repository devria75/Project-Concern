using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour {

    [SerializeField]
    private static float speed = 12.0f;
    [SerializeField]
    private float lookSensitiy = 3.0f;

    private Rigidbody rb;
    private Vector3 velocity = Vector3.zero;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	//ideally, this should be split to two with player controller and the motor it moves
	void Update () {

        //movement
        float _vInput = Input.GetAxisRaw("Vertical");
        float _hInput = Input.GetAxisRaw("Horizontal");

        Vector3 _movHorizontal = transform.right * _hInput;
        Vector3 _movVertical = transform.forward * _vInput;
        Vector3 _velocity = _movHorizontal + _movVertical;

        if (_velocity != Vector3.zero)
            rb.MovePosition(rb.position + _velocity * speed * Time.deltaTime);   

		

	}
}
