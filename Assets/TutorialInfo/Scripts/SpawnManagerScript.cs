using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.TutorialInfo.Scripts
{
	public class SpawnManagerScript: MonoBehaviour
	{
		public GameObject[] enemyPrefabs;
		//public GameObject powerupPrefab;

		private float spawnRange = 9.0f;
		private float spawnPosZ = 20.0f;
		public int enemyCount = 10;

		public float spawnRate = 3.0f;
		public float startDelay = 1.0f;

		public int waveNumber = 1;
		void Start()
		{
			InvokeRepeating(nameof(SpawnEnemy), startDelay, spawnRate);
		}
		void Update()
		{
			
		}
		private Vector3 GenerateSpawnPosition()
		{
			float spawnPosX = UnityEngine.Random.Range(-spawnRange, spawnRange);
			Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
			return randomPos;
		}
		private void SpawnEnemy()
		{		
			int animalIndex = UnityEngine.Random.Range(0, enemyPrefabs.Length);
			Instantiate(enemyPrefabs[animalIndex], GenerateSpawnPosition(), enemyPrefabs[animalIndex].transform.rotation);	
		}
	}
}
