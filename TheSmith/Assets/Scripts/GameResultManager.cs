using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameResultManager : MonoBehaviour {

	// Use this for initialization
	public Text TextTimberUI;
	public Text TextMoneyUI;
	void Start () {
		//TextTimberUI =  ;
	}
	
	// Update is called once per frame
	void Update () {
		TextTimberUI.text = "This is "+starValue;
		if( TimeManager.timeValue == 1)
		{
			calculateStar();
			TextTimberUI.text = "This is "+starValue;
			TextMoneyUI.text ="This is "+MoneyValue;
		}
	}

	public int starValue;
	public int timberValue;
	public int MoneyValue;
	public void calculateStar()
	{
		if( ScoreManager.ScoreValue < 6000)
		{
			starValue = 1;
			timberValue = (int)Random.Range(0,2);
			MoneyValue = (int)Random.Range(0,101);
		}
		else if(ScoreManager.ScoreValue < 11000)
		{
			starValue = 2;
			timberValue = Random.Range(1,3);
			MoneyValue = (int)Random.Range(100,201);
		}
		else
		{
			starValue = 3;
			timberValue = Random.Range(2,3);
			MoneyValue = (int)Random.Range(200,301);
		}
			
		Debug.Log( "Star = "+starValue+" Timber = "+ timberValue+" Money = "+ MoneyValue);
	}


}
