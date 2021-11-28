using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBallons : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnPoints;
    [SerializeField] private GameObject[] ballonPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawing());
    }

    // We'll wait for some time
    // spawn a balloon model at one of the spawn point

    IEnumerator StartSpawing()
    {
        yield return new WaitForSeconds(Random.Range(0.0f, 1.0f));

        int randomBalloonIndex = Random.Range(0, ballonPrefabs.Length);
        int randomSpawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(ballonPrefabs[randomBalloonIndex], spawnPoints[randomSpawnPointIndex].transform.position, Quaternion.identity);

        StartCoroutine(StartSpawing());
    }
}
