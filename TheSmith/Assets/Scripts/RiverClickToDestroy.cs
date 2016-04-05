using UnityEngine;
using System.Collections;

public class RiverClickToDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	float noteLifeTime = 0;
	float elapseTime=0;
	void Update () {
		noteLifeTime = noteLifeTime + Time.deltaTime;
		if(transform.position.z > -13.9){elapseTime += Time.deltaTime; }
	}

	void OnMouseDown()
	{


		float timeCheck = noteLifeTime - elapseTime; 
		//Destroy(gameObject);
		if(transform.position.z > -14.0f    )
		{
			
		}
		else
		{
			if( timeCheck < 0.35f) //Perfect
			{ 
				Debug.Log("Perfect"+(noteLifeTime - elapseTime));
				ScoreManager.ScoreValue += 1000;
			}
			else if( timeCheck  < 0.45f) //Good
			{ 
				Debug.Log("Good"+(noteLifeTime - elapseTime));
				ScoreManager.ScoreValue += 750;
			}
			else if( timeCheck < 0.55f) //Bad
			{ 
				Debug.Log("Bad"+(noteLifeTime - elapseTime));
				ScoreManager.ScoreValue += 500;
			}
			else //Missed
			{ 
				Debug.Log("Missed"+noteLifeTime);
			}
			Destroy(gameObject);
		}



	}
}
