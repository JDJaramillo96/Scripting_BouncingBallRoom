using UnityEngine;
using System.Collections;

public class Raycasting : MonoBehaviour {

	[SerializeField]
	private float rayLenght;
	private float rotationSensibility;

	[Header("References")]

	[SerializeField]
	private Camera gunCamera;

	void Start()
	{
		rotationSensibility = 45f;
	}

	void Update ()
	{
		if (ButtonsFunction.menuActive == false)
		{
			Vector3 rayOrigin = gunCamera.transform.position;
			Vector3 inverseHorizontalInput = new Vector3 ((Screen.width) - Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);

			Ray ray = gunCamera.ScreenPointToRay (inverseHorizontalInput);
			RaycastHit hit;

			Debug.DrawRay (rayOrigin, ray.direction * rayLenght, Color.white);

			if (Physics.Raycast (rayOrigin, ray.direction, out hit) == true)
				Debug.DrawRay (rayOrigin, ray.direction * hit.distance, Color.red);

			transform.rotation = Quaternion.Euler (0f, -ray.direction.x * rotationSensibility, 0f);
		}
	}
}