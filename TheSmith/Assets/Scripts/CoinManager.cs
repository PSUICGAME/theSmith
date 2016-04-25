using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinManager : MonoBehaviour {

	public static int MoneyValue; // Store Time value 
	Text UIMoneyText; // Connect to TimeText UI
	int moneyValue;
	Scene myScene;
	// Use this for initialization
	void Start () 
	{
		myScene = SceneManager.GetActiveScene();
		MoneyValue = 0;
		UIMoneyText = gameObject.GetComponent<Text>();
		if (myScene.name == "ForestGame")
		{
			//Debug.Log("MMM");
			UIMoneyText.text = "x "+ calculateMoneyForrest();
		}
		else if (myScene.name == "CaveGame")
		{
			//Debug.Log("MMM");
			UIMoneyText.text = "x "+ calculateMoneyCave();
		}
		else if (myScene.name == "MoutainGame")
		{
			//Debug.Log("MMM");
			UIMoneyText.text = "x "+ calculateMoneyMoutain();
		}
		else if (myScene.name == "RiverGame")
		{
			//Debug.Log("MMM");
			UIMoneyText.text = "x "+ calculateMoneyRiver();
		}
	
	}

	// Update is called once per frame
	void Update () 
	{

	}

	int calculateMoneyForrest()
	{
		if( ScoreManager.ScoreValue < 6000)
		{
			
			moneyValue = (int)Random.Range(0,101);
		}
		else if(ScoreManager.ScoreValue < 11000)
		{
			
			moneyValue = (int)Random.Range(100,201);
		}
		else
		{
			
			moneyValue = (int)Random.Range(200,301);
		}
		return moneyValue;

	}

	int calculateMoneyRiver()
	{

		if( ScoreManager.ScoreValue < 6000)
		{

			moneyValue = (int)Random.Range(0,101);
		}
		else if(ScoreManager.ScoreValue < 11000)
		{

			moneyValue = (int)Random.Range(100,201);
		}
		else
		{

			moneyValue = (int)Random.Range(200,301);
		}
		return moneyValue;

	}

	int calculateMoneyMoutain()
	{

		if( ScoreManager.ScoreValue >= 6000)
		{
			moneyValue = (int)Random.Range(200,301);

		}
		else if( ScoreManager.ScoreValue >= 4500)
		{

			moneyValue = (int)Random.Range(100,201);
		}
		else
		{
			moneyValue = (int)Random.Range(0,101);

		}
		return moneyValue;

	}

	int calculateMoneyCave()
	{
		Debug.Log("xx"+ScoreManager.ScoreValue);
		if( ScoreManager.ScoreValue < 2000)
		{
			
			moneyValue = (int)Random.Range(0,101);
		}
		else if(ScoreManager.ScoreValue < 3500)
		{

			moneyValue = (int)Random.Range(100,201);
		}
		else
		{
			
			moneyValue = (int)Random.Range(200,301);
		}
		return moneyValue;

	}

}
