using UnityEngine;
using System.Collections;

public class BoxController : MonoBehaviour {

	float speed;
	// Use this for initialization
	void Start () {
		speed =  Random.Range(5,10);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(0,0, -Time.deltaTime * speed);
	
	}
}
