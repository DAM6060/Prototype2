using UnityEngine;
namespace Assets.TutorialInfo.Scripts
{
	public class PlayerControllerTest: MonoBehaviour
	{
		public float horizontalInput;
		public float verticalInput;

		public float speed = 10.0f;

		public float xBoundLeft = -10;
		public float xBoundRight = 10;
		public float zBoundTop = 15;
		public float zBoundBottom = -6;

		public GameObject projectilePrefab;
		
		void Start()
		{
			
		}
		
		void Update()
		{
			CheckOutOfBounds();

			horizontalInput = Input.GetAxis("Horizontal");
			verticalInput = Input.GetAxis("Vertical");

			transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
			transform.Translate(verticalInput * speed * Time.deltaTime * Vector3.forward);

			if (Input.GetKeyDown(KeyCode.Space))
			{
				Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
			}

		}

		void CheckOutOfBounds()
		{
			if (transform.position.x < xBoundLeft)
			{
				transform.position = new Vector3(xBoundLeft, transform.position.y, transform.position.z);
			}
			else if (transform.position.x > xBoundRight)
			{
				transform.position = new Vector3(xBoundRight, transform.position.y, transform.position.z);
			}
			else if (transform.position.z < zBoundBottom)
			{
				transform.position = new Vector3(transform.position.x, transform.position.y, zBoundBottom);
			}
			else if (transform.position.z > zBoundTop)
			{
				transform.position = new Vector3(transform.position.x, transform.position.y, zBoundTop);
			}
		}
	}
}
