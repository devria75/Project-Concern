using UnityEngine;
using System.Collections;

public class IgnorePlayerCollider : MonoBehaviour {
    
    [SerializeField]
    private GameObject[] objs;
	
	void Start () {

        foreach(GameObject obj in objs)
        {
            Physics.IgnoreCollision(obj.GetComponent<Collider>(), GetComponent<Collider>());
        }
	}
	
}
