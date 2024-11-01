using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 0.0f;

    private int rangeMin = 3;
	private int rangeMax = 5;

	// Start is called before the first frame update
	void Start()
	{
		// Start the coroutine to spawn balls
		StartCoroutine(SpawnRandomBallCoroutine());
	}

	// Coroutine to spawn random balls at random intervals
	private IEnumerator SpawnRandomBallCoroutine()
	{
		yield return new WaitForSeconds(startDelay); // Wait for the start delay

		while (true) // Loop indefinitely
		{
			SpawnRandomBall(); // Call the method to spawn a ball

			// Generate a random interval between rangeMin and rangeMax
			float randomInterval = Random.Range(rangeMin, rangeMax);
			yield return new WaitForSeconds(randomInterval); // Wait for the random interval
															
		}
	}

	// Spawn random ball at random x position at top of play area
	void SpawnRandomBall()
	{
		// Generate random spawn position
		Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

		// Instantiate a random ball prefab at the spawn position
		int randomIndex = Random.Range(0, ballPrefabs.Length);
		Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[randomIndex].transform.rotation);
	}
}
