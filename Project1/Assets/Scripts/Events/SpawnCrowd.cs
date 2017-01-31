using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnCrowd : MonoBehaviour {

    //[SerializeField]
    //private GameObject parentOfSpawaner;
    [SerializeField]
    private float rate = 5f;
    [SerializeField]
    private float increaseSpawnSpeed = 1f;
    [SerializeField]
    private float decreaseSpawnSpeed = 1f;
    [SerializeField]
    private float spawnRateMax = 10f;

    private List<GameObject> childList;
    private List<GameObject> visiableChild;
    private float currentTime;
    void Start () {
        visiableChild = new List<GameObject>();
        childList = new List<GameObject>();

        for(int i = 0; i < transform.childCount; i++)
        {
            childList.Add(transform.GetChild(i).gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            displayChild();
            currentTime = rate;
        }
    }

    public void IncreaseSpawnRate()
    {
        rate = Mathf.Clamp(rate - increaseSpawnSpeed, 0, spawnRateMax);
        currentTime = Mathf.Clamp(currentTime - increaseSpawnSpeed, 0, spawnRateMax);
    }

    public void Decreaserate()
    {
        rate = Mathf.Clamp(rate + increaseSpawnSpeed, 0, spawnRateMax);
        currentTime = Mathf.Clamp(currentTime + increaseSpawnSpeed, 0, spawnRateMax);
    }

    private void displayChild()
    {
        int num = Random.Range(0, childList.Count - 1);

        GameObject child = childList[num];

        child.gameObject.SetActive(true);

        visiableChild.Add(child);
        childList.RemoveAt(num);
    }
}
