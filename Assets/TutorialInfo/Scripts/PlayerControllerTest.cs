using UnityEngine;
namespace Assets.TutorialInfo.Scripts
{
	public class PlayerControllerTest: MonoBehaviour
	{
		public float horizontalInput;
		public float speed = 10.0f;
		public int xBoundLeft = -10;
		public int xBoundRight = 10;
		public GameObject projectilePrefab;
		private void Start()
		{
			
		}
		private void Update()
		{
			if (transform.position.x < xBoundLeft)
			{
				transform.position = new Vector3(xBoundLeft, transform.position.y, transform.position.z);
			}
			else if (transform.position.x > xBoundRight)
			{
				transform.position = new Vector3(xBoundRight, transform.position.y, transform.position.z);
			}
			horizontalInput = Input.GetAxis("Horizontal");
			transform.transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);

			if (Input.GetKeyDown(KeyCode.Space))
			{
				Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
			}

		}
	}
}
