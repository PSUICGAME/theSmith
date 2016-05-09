using UnityEngine;
using System.Collections;

public class GemStoneController : MonoBehaviour 

{

	static int dif;

	float speedx = 9.89f;

	void Start()
	{
		dif = PlayerPrefs.GetInt ("Dif");

		if (dif == 0) 
		{
			speedx = 10f;
		} 
		else if (dif == 1) 
		{

			speedx = 20f;
		} 
		else 
		{
			speedx = 30f;
		}
	}
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
		}
	}

	bool dragging = false;
	float distance;

	void OnMouseDown()
	{
		dragging = true;
		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
	}
	void OnMouseUp()
	{
		dragging = false;
	}
	void OnCollisionEnter2D(Collision2D hitObject)
	{
		if( hitObject.gameObject.tag == "ItemBox" )
			{
			speedx = 0;	
			ScoreManager.ScoreValue += 150;
			}
	}

}
