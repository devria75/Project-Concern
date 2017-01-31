using UnityEngine;
using System.Collections;

public class ShyAway : MonoBehaviour {

    [SerializeField]
    private float speedModifier = 4f;

    private Transform person;
    private HelpPersonMovement movement;

    void Start()
    {
        GameObject parent = this.transform.parent.gameObject;
        person = parent.transform;
        movement = parent.GetComponent<HelpPersonMovement>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            person.LookAt(2 * transform.position - other.transform.position);

            movement.setSpeed(speedModifier);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            movement.setSpeed(0);
        }
    }



}
