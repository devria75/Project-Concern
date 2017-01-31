using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class GenericCrowdMover : MonoBehaviour {

    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private float minRot = 90f;
    [SerializeField]
    private float maxRot = 270f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.MovePosition(rb.position + transform.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        transform.Rotate(new Vector3(0, Random.Range(minRot, maxRot), 0));
    }

}
