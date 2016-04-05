using UnityEngine;
using System.Collections;

public class RiverGamePlayManager : MonoBehaviour {

	public GameObject[] WaterPrefabs;
	public GameObject[] SpawnPointWater;
	public GameObject panelResult;
	// Use this for initialization
	void Start () {
		panelResult.SetActive(false);
		InvokeRepeating("generateNote", 2.0f, 2.0f);
	}

	void generateNote()
	{
		int waterIndex= (int)Random.Range(0,3);
		int SPwaterIndex= (int)Random.Range(0,3);
		GameObject CloneNote = Instantiate( WaterPrefabs[waterIndex],
			SpawnPointWater[SPwaterIndex].transform.position,
			Quaternion.identity) as GameObject;
		Destroy(CloneNote,20.0f);
	}

	float timeTemp = 40;
	// Update is called once per frame
	void Update () {

		timeTemp = timeTemp - Time.deltaTime;
		TimeManager.timeValue = (int)timeTemp;

		if(TimeManager.timeValue < 1)
		{
			panelResult.SetActive(true);
			Time.timeScale = 0;
		}

	}
}
