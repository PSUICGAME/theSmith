using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLevelManager : MonoBehaviour {

	public void gotoShop()
	{
		SceneManager.LoadScene("Shop");
	}

	public void gotoAdventure()
	{
		SceneManager.LoadScene("Adventure");
	}

	public void gotoMain()
	{
		SceneManager.LoadScene("GameLevel1");
	}

	public Image dayTime;
	public Image NightTime;
	public Text timeTextUI;
	public Slider expSliderUI;
	int expValue;

	void Update()
	{
		if( Input.GetKey(KeyCode.Space) )
		{
			dayTime.enabled = false;
			NightTime.enabled = true;
			expValue++;
			expSliderUI.value = expValue; 
		}
		else
		{
			dayTime.enabled = true;
			NightTime.enabled = false;
			//expValue--;
			//expSliderUI.value = expValue;
		}

		timeTextUI.text = Time.deltaTime.ToString();
	}
}
