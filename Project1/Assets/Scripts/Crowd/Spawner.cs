using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] CrowdSet;
	public float spawnRate = 3f;
    public float increaseSpawnSpeed = 1f;
    public float decreaseSpawnSpeed = 1f;
    public float spawn = 3f;
	public Transform[] spawnSpot;
    private float currentTime;
    public float spawnRateMax = 10f;
	// Use this for initialization
	void Start () {

        currentTime = spawnRate;
	}

	void Spawn ()
	{
		int spawnPointIndex = Random.Range (0, spawnSpot.Length);

		Instantiate (CrowdSet[Random.Range(0, CrowdSet.Length)], spawnSpot[spawnPointIndex].position, spawnSpot[spawnPointIndex].rotation);
	}
	
	// Update is called once per frame
	void Update () {
        currentTime -= Time.deltaTime;

        if(currentTime <= 0)
        {
            Spawn();
            currentTime = spawnRate;
        }
	
	}

    public void IncreaseSpawnRate()
    {
        spawnRate = Mathf.Clamp(spawnRate - increaseSpawnSpeed, 0, spawnRateMax);
        currentTime = Mathf.Clamp(currentTime - increaseSpawnSpeed, 0, spawnRateMax);
    }

    public void DecreaseSpawnRate()
    {
        spawnRate = Mathf.Clamp(spawnRate + increaseSpawnSpeed, 0, spawnRateMax);
        currentTime = Mathf.Clamp(currentTime + increaseSpawnSpeed, 0, spawnRateMax);
    }
}
