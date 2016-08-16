using UnityEngine;
using System.Collections;

public class DestroyByTrigger : MonoBehaviour {

	void OnTriggerExit(Collider other)
	{
		Destroy (other.gameObject);
	}
}