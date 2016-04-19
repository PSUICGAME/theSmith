using UnityEngine;
using System.Collections;

public class MountainGamePlayManager : MonoBehaviour {

	public GameObject[] RockPrefabs;
	public GameObject panelResult;

	public GameObject GoldcoinPrefabs;
	// Use this for initialization
	void Start () {
		panelResult.SetActive(false);
		InvokeRepeating("generateObstacle",2.0f,2.0f);
		InvokeRepeating("generateGoldMedal",2.0f,2.0f);
	}

	void generateObstacle()
	{
		float xRandom = Random.Range(-4.2f,4.2f);

		GameObject cloneRock = Instantiate( RockPrefabs[0],
			new Vector3(xRandom, 0.5f ,30),
			Quaternion.identity) as GameObject;
		Destroy(cloneRock,30.0f);
	}

	void generateGoldMedal()
	{
		float xRandom = Random.Range(-4.2f,4.2f);

		GameObject cloneGoldenMedal = Instantiate( GoldcoinPrefabs,
			new Vector3(xRandom, 0.5f ,30),
			Quaternion.identity) as GameObject;
		Destroy(cloneGoldenMedal,30.0f);
	}

	
	float timeTemp = 10;
	// Update is called once per frame
	void Update () {


		timeTemp = timeTemp - Time.deltaTime;
		TimeManager.timeValue = (int)timeTemp;

		if(TimeManager.timeValue < 1)
		{
			calculateStone();
			panelResult.SetActive(true);
			Time.timeScale = 0;
		}

	}

	void calculateStone()
	{
		if( ScoreManager.ScoreValue < 4500)
		{
			// get 1 stone
			PlayerPrefs.SetInt("mStone",2); 
		}
		else if( ScoreManager.ScoreValue < 6000)
		{
			// get 2 stones
			PlayerPrefs.SetInt("mStone",1);
		}
		else
		{

		}
	}
}
