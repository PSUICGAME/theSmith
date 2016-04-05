using UnityEngine;
using System.Collections;

public class MountainGamePlayManager : MonoBehaviour {

	public GameObject[] RockPrefabs;
	public GameObject panelResult;
	// Use this for initialization
	void Start () {
		panelResult.SetActive(false);
		InvokeRepeating("generateObstacle",2.0f,2.0f);
	}

	void generateObstacle()
	{
		float xRandom = Random.Range(-4.2f,4.2f);

		GameObject cloneRock = Instantiate( RockPrefabs[0],
			new Vector3(xRandom, 0.5f ,30),
			Quaternion.identity) as GameObject;
		Destroy(cloneRock,30.0f);
	}

	
	float timeTemp = 30;
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
