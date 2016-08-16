using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonsFunction : MonoBehaviour {

	public static bool menuActive;

	[Header("References")]

	[SerializeField]
	private GameObject menu;

	void Start ()
	{
		menuActive = true;
	}

	void Update ()
	{
		if (menuActive == true)
		{
			menu.SetActive (true);
			Time.timeScale = 0f;
		}

		if (menuActive == false)
		{
			menu.SetActive(false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown (KeyCode.P) || Input.GetKeyDown (KeyCode.Escape)) menuActive = !menuActive;

		if (Input.GetKeyDown (KeyCode.R)) SceneManager.LoadScene (0);
	}

	public void Play()
	{
		menuActive = false;
	}

	public void Restart()
	{
		SceneManager.LoadScene(0);
	}

	public void Exit()
	{
		Application.Quit ();
	}
}