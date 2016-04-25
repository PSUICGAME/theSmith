using UnityEngine;
using System.Collections;

public class GemStoneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//randomSpeed();
	}

	float speedx = 9.89f;
	public void randomSpeed()
	{
		speedx = Random.Range(5.0f,15.0f);
	}
	// Update is called once per frame
	void Update () {

		if(  !dragging )
		{
			transform.Translate(Time.deltaTime * speedx , 0, 0);
		}
		else
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 rayPoint = ray.GetPoint(distance);
			transform.position = rayPoint;
		}
		if(transform.position.x > 12.0)
		{
			Destroy(gameObject);
			ScoreManager.ScoreValue -= 150;
		}
	}

	bool dragging = false;
	float distance;

	void OnMouseDown()
	{
		dragging = true;
		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
		Debug.Log("Down");
	}
	void OnMouseUp()
	{
		dragging = false;
		Debug.Log("Up");
	}

	/*
	void OnTriggerEnter(Collider2D coll)
	{
		speedx = 0;
	}
	*/

	void OnCollisionEnter2D(Collision2D hitObject)
	{
		Debug.Log("Hittttttttt");
		if( hitObject.gameObject.tag == "ItemBox" )
			{
			speedx = 0;	
			ScoreManager.ScoreValue += 150;
			//Debug.Log("Hixxxxxxx");
			}
	}

}
