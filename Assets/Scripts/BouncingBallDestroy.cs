using UnityEngine;
using System.Collections;

public class BouncingBallDestroy : MonoBehaviour {

	[SerializeField]
	private float destroyTime;

	void Start ()
	{
		StartCoroutine (DestroyIt ());
	}

	IEnumerator DestroyIt()
	{
		yield return new WaitForSeconds (destroyTime);
		Destroy (gameObject);
	}
}