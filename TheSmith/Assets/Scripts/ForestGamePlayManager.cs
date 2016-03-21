using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ForestGamePlayManager : MonoBehaviour {

	public GameObject[] spawnTreePosition;
	public GameObject treePrefab;
	public GameObject panelResult;

	public static bool[] checkTree = new bool[4];
	int RandomTreeIndex;


	public void spawnTree()
	{
		RandomTreeIndex = Random.Range(0,4);


		if( checkTree[RandomTreeIndex] == false)
		{
			checkTree[RandomTreeIndex] = true;
		GameObject cloneTree = Instantiate(treePrefab,
			spawnTreePosition[RandomTreeIndex].transform.position
			, Quaternion.identity) as GameObject;
			cloneTree.name = "tree"+RandomTreeIndex;
		}
		
	}
	// Use this for initialization
	void Start () 
	{
		InvokeRepeating("spawnTree",2.0f,2.0f);
		panelResult.SetActive(false);
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





















