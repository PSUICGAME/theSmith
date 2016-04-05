using UnityEngine;
using System.Collections;

public class DragTransform : MonoBehaviour {

	 Color mouseOverColor = Color.blue;
	 Color originalColor = Color.yellow;
	 bool dragging = false;
	 float distance;


	void OnMouseEnter()
	{
		GetComponent<Renderer>().material.color = mouseOverColor;
		Debug.Log("Enter");
	}

	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = originalColor;
		Debug.Log("Exit");
	}

	void OnMouseDown()
	{
		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
		dragging = true;
		Debug.Log("Down");
	}

	void OnMouseUp()
	{
		dragging = false;
		Debug.Log("Up");
	}

	void Update()
	{
		if (dragging)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 rayPoint = ray.GetPoint(distance);
			transform.position = rayPoint;
		}
	}
}
