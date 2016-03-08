using UnityEngine;
using System.Collections;

public class ForestGamePlayManager : MonoBehaviour {

	public GameObject[] spawnTreePosition;
	public GameObject treePrefab;

	public void spawnTree()
	{
		int RandomTreeIndex = Random.Range(0,4);

		GameObject cloneTree = Instantiate(treePrefab,
			spawnTreePosition[RandomTreeIndex].transform.position
			, Quaternion.identity) as GameObject;

		Destroy(cloneTree,3.0f);
		
	}
	// Use this for initialization
	void Start () {
		InvokeRepeating("spawnTree",2.0f,2.0f);
	}

	float timeTemp = 50;
	// Update is called once per frame
	void Update () {
		timeTemp = timeTemp - Time.deltaTime;
		Timemanger.timeValue = (int)timeTemp; 
	
	}
}
