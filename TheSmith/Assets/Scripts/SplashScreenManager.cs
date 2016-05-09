using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class SplashScreenManager : MonoBehaviour 

{
	float timer;
	void Update()
	{
		timer += Time.deltaTime;
		if (timer > 3) 
		{
			SceneManager.LoadScene ("GameMenu");
		}
	}
}
