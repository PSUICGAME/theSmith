using UnityEngine;
using System.Collections;

public class DragObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	float x;
	float y;
	// Update is called once per frame
	void Update () {
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
		//Debug.Log("Update");
	}

	void OnMouseDrag(){
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x,y,10.0f));
		Debug.Log("Up");
	}
}
