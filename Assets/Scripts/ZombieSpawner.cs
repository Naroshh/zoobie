using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab;
    [SerializeField] private float spawnTimer;
    [SerializeField] private int spawnAmount;

    private float timeRemaining;

    private Transform[] spawnPositions;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = spawnTimer;
        spawnPositions = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; ++i)
        {
            spawnPositions[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            timeRemaining += spawnTimer;

            for (int i = 0; i < spawnAmount; ++i)
            {
                GameObject newZombie = Instantiate(zombiePrefab);
                newZombie.transform.position = spawnPositions[Random.Range(0, spawnPositions.Length)].position;
            }
        }
    }
}
