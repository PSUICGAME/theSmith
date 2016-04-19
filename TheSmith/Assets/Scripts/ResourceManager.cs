using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResourceManager : MonoBehaviour {

	public static int ResourceValue; // Store Time value 
	Text UIResourceText; // Connect to TimeText UI
	int timberValue;
	Scene myScene;
	// Use this for initialization
	void Start () 
	{
		myScene = SceneManager.GetActiveScene();
		ResourceValue = 0;
		UIResourceText = gameObject.GetComponent<Text>();
	
	}

	// Update is called once per frame
	void Update () 
	{
		if (myScene.name == "MoutainGame")
		{
			Debug.Log("MMM");
			UIResourceText.text = "x "+ calculateStone();
		}
		else if (myScene.name == "ForrestGame")
		{
			UIResourceText.text = "x "+ calculateTimber();
		}
	}

	int calculateStone()
	{
		if( ScoreManager.ScoreValue >= 6000)
		{
			// get 1 stone
			PlayerPrefs.SetInt("mStone",2); 
			return 2;
		}
		else if( ScoreManager.ScoreValue >= 4500)
		{
			// get 2 stones
			PlayerPrefs.SetInt("mStone",1);
			return 1;
		}
		else
		{
			return 0;
		}
		return 0;
	}

	int calculateTimber()
	{

		if( ScoreManager.ScoreValue < 6000)
		{
			
			timberValue = (int)Random.Range(0,2);

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
		//Debug.Log( "Star = "+starValue+" Timber = "+ timberValue+" Money = "+ MoneyValue);
	}

}
