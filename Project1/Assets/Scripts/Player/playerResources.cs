using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerResources : MonoBehaviour {

	public int money = 15;
	public Text textElement;

	// Use this for initialization
	void Start () {
		textElement.text = money.ToString();
	}

	void OnGui() {
		//GUI.Label(new Rect(0,0,100,100), money.ToString());
		textElement.text = money.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public void addMoney(int Money){
		money += Money;
		textElement.text = money.ToString();
	}

	public void subtractMoney(int Money){
        if (this.money > 0)
        {
            this.money -= Money;
            textElement.text = money.ToString();
        }
	}

    public int getMoney()
    {
        return money;
    }
}
