using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int ScoreValue; // Store Time value 
	Text UIScoreText; // Connect to TimeText UI
	// Use this for initialization
	void Start () 
	{

		ScoreValue = 0;
		UIScoreText = gameObject.GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		UIScoreText.text = "Score: "+ ScoreValue;
	}
}
