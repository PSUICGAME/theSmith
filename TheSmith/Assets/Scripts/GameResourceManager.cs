using UnityEngine;
using System.Collections;

public class GameResourceManager : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (TimeManager.timeValue == 0) 
		{
			calculateStar ();
		}
	}
	public void calculateStar()
	{
		if (ScoreManager.ScoreValue < 6000) 
		{
			Debug.Log (ScoreManager.ScoreValue);
		}
		else if (ScoreManager.ScoreValue < 11000) 
		{
			Debug.Log (ScoreManager.ScoreValue);
		}
		else 
		{
			Debug.Log (ScoreManager.ScoreValue);
		}
	}
}
