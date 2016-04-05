using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameResultManager : MonoBehaviour {

	// Use this for initialization
	public Text TextTimberUI;
	public Text TextMoneyUI;
	public Image star1,star2,star3;
	public Sprite StarImageOn;
	public Sprite StarImageOff;
	void Start () {
		//TextTimberUI =  ;
	}
	
	// Update is called once per frame
	void Update () {
		//TextTimberUI.text = "This is "+starValue;
		if( TimeManager.timeValue == 1)
		{
			calculateStar();
			TextTimberUI.text = "x "+timberValue;
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
			star1.sprite = StarImageOn;
			starValue = 1;
			timberValue = (int)Random.Range(0,2);
			MoneyValue = (int)Random.Range(0,101);
		}
		else if(ScoreManager.ScoreValue < 11000)
		{
			star1.sprite = StarImageOn;
			star2.sprite = StarImageOn;
			starValue = 2;
			timberValue = Random.Range(1,3);
			MoneyValue = (int)Random.Range(100,201);
		}
		else
		{
			star1.sprite = StarImageOn;
			star2.sprite = StarImageOn;
			star3.sprite = StarImageOn;
			starValue = 3;
			timberValue = Random.Range(2,3);
			MoneyValue = (int)Random.Range(200,301);
		}
			
		Debug.Log( "Star = "+starValue+" Timber = "+ timberValue+" Money = "+ MoneyValue);
	}


}
