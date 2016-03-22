using UnityEngine;
using System.Collections;

public class CaveGamePlayManager : MonoBehaviour 
{
	public GameObject[] magicStone;
	public Transform[] spawnMagicStone;
	public GameObject panelResult;
	// Use this for initialization
	void Start () 
	{
		panelResult.SetActive(false);
		InvokeRepeating("generateGemStone",1.5f,1.5f);
	}
	public void generateGemStone()
	{
		int spawnMagicStoneIndex = (int)Random.Range (0, 2);
		int magicStoneIndex = (int)Random.Range (0, 4);
		GameObject cloneJewel = Instantiate(magicStone[magicStoneIndex], 
			spawnMagicStone [spawnMagicStoneIndex].transform.position, 
								Quaternion.identity) as GameObject;
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
