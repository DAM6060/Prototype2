using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.TutorialInfo.Scripts
{
	public class DestroyOutOfBounds : MonoBehaviour
	{
		private float topBound = 30.0f;
		private float lowerBound = -10.0f;
		private float LeftBound = -12.0f;
		private float RightBound = 12.0f;
		void Start()
		{

		}
		void Update()
		{
			if (transform.position.z > topBound)
			{
				Destroy(gameObject);
			}
			else if (transform.position.z < lowerBound)
			{
				Destroy(gameObject);
			}
			else if (transform.position.x < LeftBound)
			{
				Destroy(gameObject);
			}
			else if (transform.position.x > RightBound)
			{
				Destroy(gameObject);
			}
			
		}
	}
}
