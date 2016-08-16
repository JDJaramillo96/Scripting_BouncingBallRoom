using UnityEngine;
using System.Collections;

[System.Serializable]
public class Limits
{
	public float xMin, xMax, yMin, yMax, zMin, zMax;
}

public class RandomPosition : MonoBehaviour {

	public Limits limits;

	void Start ()
	{
		transform.position = new Vector3 (

			Random.Range (limits.xMin, limits.xMax),
			Random.Range (limits.yMin, limits.yMax),
			Random.Range (limits.zMin, limits.zMax));
	}
}