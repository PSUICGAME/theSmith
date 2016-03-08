using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timemanger : MonoBehaviour {

	public static float timeValue; // Store Time value 
	Text UITimeText; // Connect to TimeText UI
	// Use this for initialization
	void Start () {

		timeValue = 30;
		UITimeText = gameObject.GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () {
		UITimeText.text = "Time: "+ timeValue;
	
	}
}
