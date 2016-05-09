using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	float speed = 10;
	// Update is called once per frame
	void Update () 
	{
		float leftRight = Input.GetAxis("Horizontal");
		transform.Translate(leftRight*Time.deltaTime*speed,0,0);
	
	}

	void OnCollisionEnter(Collision hitObject)
	{
		if( hitObject.gameObject.name == "GoldenMedal(Clone)")
		{
			Destroy(hitObject.gameObject);
			ScoreManager.ScoreValue += 3000;
				//Debug.Log("XXXX");
		}
	}




}
