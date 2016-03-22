using UnityEngine;
using System.Collections;

public class GemStoneController : MonoBehaviour 
{
	float speed = 7.5f;
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}
}
