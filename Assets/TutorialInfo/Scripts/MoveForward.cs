using UnityEngine;
namespace Assets.TutorialInfo.Scripts
{
	public class MoveForward : MonoBehaviour
	{
		public float speed = 40.0f;
		void Start() 
		{
			
		}
		private void Update()
		{
			transform.Translate(speed * Time.deltaTime * Vector3.forward);
		}
	}
}
