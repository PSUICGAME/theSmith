using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float leftRight = Input.GetAxis("Horizontal");
		transform.Translate(leftRight*Time.deltaTime,0,0);
	
	}
}
