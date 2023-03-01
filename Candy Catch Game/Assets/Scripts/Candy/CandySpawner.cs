using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    private float minX = -6f;
    private float maxX = 6f;
    private float minY = 4f;
    private float maxY = 4f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCandy", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCandy()
    {
        int randomNum = Random.Range(0, prefabsToSpawn.Length);

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector3 randomPosition = new Vector3(randomX, randomY, 0f);

        Instantiate(prefabsToSpawn[randomNum], randomPosition, Quaternion.identity);
    }
}