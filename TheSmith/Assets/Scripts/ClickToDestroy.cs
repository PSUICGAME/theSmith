using UnityEngine;
using System.Collections;

public class ClickToDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	float treeLifeTime = 10;
	// Update is called once per frame
	void Update () {
		treeLifeTime = treeLifeTime - Time.deltaTime;
		
	}

	int mouseDownCount=0;
	string subIndex;
	int TreeIndex;
	void OnMouseDown()
	{
		mouseDownCount++;

		if ( mouseDownCount > 2)
		{
			ScoreManager.ScoreValue = ScoreManager.ScoreValue + (int)(treeLifeTime * 100);
			subIndex = gameObject.name;

			TreeIndex = int.Parse(subIndex.Substring(4) );
			ForestGamePlayManager.checkTree[TreeIndex] = false;
			Destroy(gameObject);
		}
	}

}
