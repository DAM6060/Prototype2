using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.TutorialInfo.Scripts
{
	public class DetectCollision : MonoBehaviour
	{
		void Start()
		{
		}
		void Update()
		{
		}
		private void OnTriggerEnter(Collider other)
		{
			Destroy(gameObject);
			Destroy(other.gameObject);
		}
	}
}
