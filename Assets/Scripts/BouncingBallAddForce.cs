using UnityEngine;
using System.Collections;

public class BouncingBallAddForce : MonoBehaviour {

	[SerializeField]
	private float speed;

	void Start ()
	{
		gameObject.GetComponent<Rigidbody> ().AddForce (transform.forward * -speed);
	}
}