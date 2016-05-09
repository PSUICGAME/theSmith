using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLevelManager : MonoBehaviour 

{
	static int stage;
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

	public void gotoForest()
	{
		SceneManager.LoadScene("ForestGame");
		stage = 0;
		PlayerPrefs.SetInt ("Stage", stage);
	}

	public void gotoCave()
	{
		SceneManager.LoadScene("CaveGame");
		stage = 1;
		PlayerPrefs.SetInt ("Stage", stage);
	}

	public void gotoRiver()
	{
		SceneManager.LoadScene("RiverGame");
		stage = 2;
		PlayerPrefs.SetInt ("Stage", stage);
	}

	public void gotoMoutain()
	{
		SceneManager.LoadScene("MoutainGame");
		stage = 3;
		PlayerPrefs.SetInt ("Stage", stage);
	}
}
