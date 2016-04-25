using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResourceManager : MonoBehaviour {

	public static int ResourceValue; // Store Time value 
	Text UIResourceText; // Connect to TimeText UI
	int timberValue,stoneValue,waterValue,mineralValue;
	Scene myScene;
	// Use this for initialization
	void Start () 
	{
		myScene = SceneManager.GetActiveScene();
		ResourceValue = 0;
		UIResourceText = gameObject.GetComponent<Text>();

		if (myScene.name == "MoutainGame")
		{
			//Debug.Log("MMM");
			UIResourceText.text = "x "+ calculateStone();
		}
		else if (myScene.name == "ForestGame")
		{
			UIResourceText.text = "x "+ calculateTimber();
		}
		else if (myScene.name == "RiverGame")
		{
			UIResourceText.text = "x "+ calculateWater();
		}
		else if (myScene.name == "CaveGame")
		{
			UIResourceText.text = "x "+ calculateMineral();
		}
	
	}

	// Update is called once per frame
	void Update () 
	{

	}

	int calculateStone()
	{
		Debug.Log(ScoreManager.ScoreValue);
		if( ScoreManager.ScoreValue >= 6000)
		{
			PlayerPrefs.SetInt("mStone",2); 
			stoneValue = 2;
		}
		else if( ScoreManager.ScoreValue >= 4500)
		{
			PlayerPrefs.SetInt("mStone",1);
			stoneValue = 1;
		}
		else
		{
			stoneValue = 0;
		}
		return stoneValue;
	}

	int calculateTimber()
	{
		Debug.Log(ScoreManager.ScoreValue);
		if( ScoreManager.ScoreValue < 6000)
		{
			
			timberValue = 10;//(int)Random.Range(0,2);

		}
		else if(ScoreManager.ScoreValue < 11000)
		{
	
			timberValue = Random.Range(1,3);

		}
		else
		{

			timberValue = Random.Range(2,3);
		
		}
		return timberValue;

	}

	int calculateWater()
	{

		if( ScoreManager.ScoreValue < 6000)
		{

			waterValue = (int)Random.Range(0,2);

		}
		else if(ScoreManager.ScoreValue < 11000)
		{

			waterValue = Random.Range(1,3);

		}
		else
		{

			waterValue = Random.Range(2,3);

		}
		return waterValue;

	}

	int calculateMineral()
	{
		Debug.Log(ScoreManager.ScoreValue);
		if( ScoreManager.ScoreValue < 2000)
		{

			mineralValue = (int)Random.Range(0,2);

		}
		else if(ScoreManager.ScoreValue < 3500)
		{

			mineralValue = Random.Range(1,3);

		}
		else
		{

			mineralValue = Random.Range(2,3);

		}
		return mineralValue;

	}

}
