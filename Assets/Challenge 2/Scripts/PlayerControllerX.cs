using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
	public GameObject dogPrefab;
	public float timer = 0.0f;
	public float allowedSpawnRate = 2.0f;

	// Update is called once per frame
	void Update()
	{

		timer += Time.deltaTime;
		
		if (timer > allowedSpawnRate && Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
			timer = 0.0f;
		}

	}
}
