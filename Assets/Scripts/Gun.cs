using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gun : MonoBehaviour, IWeapon{

	private int ammo;
	private int ammoCount;
	[SerializeField]
	private int totalAmmo;
	[SerializeField]
	private int magazineCapacity;
	[SerializeField]
	private float speed;

	[Header("References")]

	[SerializeField]
	private Rigidbody bullet;
	[SerializeField]
	private Text ammoText;

	void Start()
	{
		Reload ();
		ammoText.text = "";
	}

	void Update ()
	{
		if (ButtonsFunction.menuActive == false)
		{
			if (Input.GetButtonDown ("Fire1"))
			{
				if (ammo > 0)
				{
					Shoot ();
					ammo--;
					ammoCount++;
				}
				else
				{
					if (ammoCount < totalAmmo)
						ammoText.text = "No ammo";
					else
						ammoText.text = "No ammo remaining";
				}
			}

			if (Input.GetButtonDown ("Fire2"))
			{
				if (ammoCount < totalAmmo)
				{
					Reload ();
					ammoText.text = "";
				}
			}
		}
	}

	public virtual void Shoot()
	{
		Rigidbody bulletRb = Instantiate (bullet, transform.position - transform.forward, bullet.transform.rotation) as Rigidbody;
		bulletRb.AddForce (transform.forward - (transform.up * 2) * -speed);
	}

	public virtual void Reload()
	{
		ammo = magazineCapacity;
	}
}