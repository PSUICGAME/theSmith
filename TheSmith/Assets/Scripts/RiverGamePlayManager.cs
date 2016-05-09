using UnityEngine;
using System.Collections;

public class RiverGamePlayManager : MonoBehaviour {

	static int dif;
	public GameObject[] WaterPrefabs;
	public GameObject[] SpawnPointWater;
	public GameObject panelResult;
	// Use this for initialization
	void Start () 
	{
		dif = PlayerPrefs.GetInt ("Dif");
		panelResult.SetActive(false);
		if (dif == 0) 
		{
			InvokeRepeating ("generateNote", 1.5f, 1.5f);
		}
		else if (dif == 1) 
		{
			InvokeRepeating ("generateNote", 2.0f, 2.0f);
		}
		else 
		{
			InvokeRepeating ("generateNote", 2.5f, 2.5f);
		}
	}

	void generateNote()
	{
		int waterIndex= (int)Random.Range(0,3);
		int SPwaterIndex= (int)Random.Range(0,3);
		GameObject CloneNote = Instantiate( WaterPrefabs[waterIndex],
			SpawnPointWater[SPwaterIndex].transform.position,
			Quaternion.identity) as GameObject;
	}

	float timeTemp = 40;
	// Update is called once per frame
	void Update () 
	{
		timeTemp = timeTemp - Time.deltaTime;
		TimeManager.timeValue = (int)timeTemp;

		if(TimeManager.timeValue < 1)
		{
			panelResult.SetActive(true);
			Time.timeScale = 0;
		}
	}
}
