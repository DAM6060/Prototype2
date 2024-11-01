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
		}
	}
}
