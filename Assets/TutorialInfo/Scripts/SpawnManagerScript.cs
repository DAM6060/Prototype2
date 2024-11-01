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
		//Top spawn fields
		private float spawnRangeX = 9.0f;
		private float spawnPosZ = 20.0f;


		//Right Spawn fields // Left with inverted values
		private float spanwMidZ = 9.0f;
		private float spanwRangeZRanger = 5.0f;
		private float spawnPosX =24.0f;

		


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
		private Vector3 GenerateSpawnPosition(int spawnPointCoding)
		{
			
			switch (spawnPointCoding)
			{
				case 0:
					return new Vector3(spawnPosX, 0, UnityEngine.Random.Range(spanwMidZ - spanwRangeZRanger, spanwMidZ + spanwRangeZRanger));
				case 1:
					return new Vector3(-spawnPosX, 0, UnityEngine.Random.Range(spanwMidZ - spanwRangeZRanger, spanwMidZ + spanwRangeZRanger));
				default:
					return new Vector3(UnityEngine.Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
			
			}
			
		}
		private void SpawnEnemy()
		{
			// D3 to determin if spawn position is left or right or Top
			int spawnPointCoding = UnityEngine.Random.Range(0, 3);
			//1 = Left spawn point, enemy will move to the right
			//2 = Right spawn point, enemy will move to the left
			//3 = Top spawn point, enemy will move to the bottom

			//Based on spanw position set quaterion

			int animalIndex = UnityEngine.Random.Range(0, enemyPrefabs.Length);
			Quaternion quaterion;
			switch (spawnPointCoding)
			{
				case 0:
					quaterion = Quaternion.Euler(0, -90, 0);
					break;
				case 1:
					quaterion = Quaternion.Euler(0, 90, 0);
					break;
				default:
					quaterion = enemyPrefabs[animalIndex].transform.rotation;
					break;
			}

			Instantiate(enemyPrefabs[animalIndex], GenerateSpawnPosition(spawnPointCoding), quaterion);	
		}
	}
}
