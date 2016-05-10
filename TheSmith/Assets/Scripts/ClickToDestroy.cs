using UnityEngine;
using System.Collections;

public class ClickToDestroy : MonoBehaviour {


	float treeLifeTime;
	static int dif;
	AudioSource audioSource;

	void Start()
	{
		audioSource = GetComponent<AudioSource> ();
		dif = PlayerPrefs.GetInt ("Dif");
		if (dif == 0)
		{
			treeLifeTime = 10;
		}
		else if (dif == 1)
		{

			treeLifeTime = 8;
		}
		else
		{
			treeLifeTime = 6;
		}
	}
	void Update () 
	{
		treeLifeTime = treeLifeTime - Time.deltaTime;
	}

	int mouseDownCount=0;
	string subIndex;
	int TreeIndex;
	void OnMouseDown()
	{
		audioSource.Play ();
		mouseDownCount++;
		genEffect();
		if (dif == 0) 
		{
			if (mouseDownCount > 2) 
			{
				ScoreManager.ScoreValue = ScoreManager.ScoreValue + (int)(treeLifeTime * 100);
				subIndex = gameObject.name;

				TreeIndex = int.Parse (subIndex.Substring (4));
				ForestGamePlayManager.checkTree [TreeIndex] = false;
				Destroy (gameObject);
			}
		}
		else if (dif == 1) 
		{
			if (mouseDownCount > 3) 
			{
				ScoreManager.ScoreValue = ScoreManager.ScoreValue + (int)(treeLifeTime * 100);
				subIndex = gameObject.name;

				TreeIndex = int.Parse (subIndex.Substring (4));
				ForestGamePlayManager.checkTree [TreeIndex] = false;
				Destroy (gameObject);
			}
		} 
		else 
		{
			if (mouseDownCount > 4) 
			{
				ScoreManager.ScoreValue = ScoreManager.ScoreValue + (int)(treeLifeTime * 100);
				subIndex = gameObject.name;

				TreeIndex = int.Parse (subIndex.Substring (4));
				ForestGamePlayManager.checkTree [TreeIndex] = false;
				Destroy (gameObject);
			}
		}
	}

	public GameObject effect1;
	void genEffect()
	{
		GameObject CloneEffect = Instantiate( effect1,
			transform.position,
			Quaternion.identity) as GameObject;
		Destroy(CloneEffect,0.25f);
	}

}
