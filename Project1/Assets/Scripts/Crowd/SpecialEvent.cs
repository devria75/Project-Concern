using UnityEngine;
using System.Collections;
//need to rename but this class is suppose to disburst the crowd around them or walk away
public class SpecialEvent : MonoBehaviour {

    public GameObject crowds;

    private GenericCrowdMover[] childs;

    void Start()
    {
        childs = crowds.GetComponentsInChildren<GenericCrowdMover>();
    }

	public void startCrowdMovement()
    {
        foreach (GenericCrowdMover c in childs)
            c.enabled = true;
    }
}
