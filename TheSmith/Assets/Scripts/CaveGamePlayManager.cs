using UnityEngine;
using System.Collections;

public class CaveGamePlayManager : MonoBehaviour {

	public GameObject[] GemStonePrefabs;
	public Transform[] spawnGemStone;
	public GameObject panelResult;
	// Use this for initialization
	void Start () {
		panelResult.SetActive(false);
		InvokeRepeating("generateGemStone", 2.0f , 1.0f );
	}

	public void generateGemStone()
	{
		int gemIndex = (int)Random.Range(0,4);
		int spawnGemIndex = (int)Random.Range(0,2);
		GameObject cloneJewel = Instantiate( GemStonePrefabs[gemIndex],
											spawnGemStone[spawnGemIndex].position,
											Quaternion.identity) as GameObject;
		

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
