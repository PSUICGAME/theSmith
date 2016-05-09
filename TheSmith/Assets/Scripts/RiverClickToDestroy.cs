using UnityEngine;
using System.Collections;

public class RiverClicktoDestroy : MonoBehaviour 

{
	public float speed;
	static int dif;

	void Start()
	{
		dif = PlayerPrefs.GetInt ("Dif");
		if (dif == 0) 
		{
			speed = -8;
		}
		else if (dif == 1) 
		{
			speed = -11;
		}
		else 
		{
			speed = -14;
		}
	}
	void OnMouseDown()
	{
		if (transform.position.z >= -15.25 || transform.position.z <= -17.5) 
		{
			Destroy (gameObject);
			ScoreManager.ScoreValue += 0;
		} 
		else if (transform.position.z >= -15.75 || transform.position.z <= -17)
		{
			Destroy (gameObject);
			ScoreManager.ScoreValue += 125;
		}
		else if (transform.position.z >= -16.25 || transform.position.z <= -16.5)
		{
			Destroy (gameObject);
			ScoreManager.ScoreValue += 250;
		}
		else
		{
			Destroy (gameObject);
			ScoreManager.ScoreValue += 500;
		}	
	}
	void Update()
	{
		transform.Translate(0 , 0, Time.deltaTime * speed);
		if (transform.position.z <= -19) 
		{
			Destroy (gameObject);
		}
	}
}
