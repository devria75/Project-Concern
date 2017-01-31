using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    [SerializeField]
    private GameObject childList;
    public Text txtEnd;

    private int health;
    int saveCount = 0;

    // Use this for initialization
    void Start () {
        health = childList.transform.childCount / 3 + 1;
	}
	
    public void updateHealth(int value)
    {
        health += value;

        if (health <= 0)
        {
          
            for(int i = 0; i < childList.transform.childCount; i++)
            {
                if (childList.transform.GetChild(i).GetComponent<helpPerson>().getHelpStatus())
                    saveCount++;
            }

            txtEnd.enabled = true;
            txtEnd.text = "You saved this many babies : " + saveCount.ToString();
            Debug.Log("Player save is " + saveCount);
        }

        Debug.Log("Player health is " + health);
    }
}
