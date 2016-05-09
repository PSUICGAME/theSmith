using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour 

{
	Text startText;
	void Start()
	{
		startText = GetComponent<Text> ();

		StartCoroutine (FlashColor ());
	}
	IEnumerator FlashColor()
	{
		yield return new WaitForSeconds (.75f);
		while (true) 
		{
			startText.enabled = true;
		    yield return new WaitForSeconds(.75f);
			startText.enabled = false;
			yield return new WaitForSeconds(.75f);
		}
	}
	void Update()
	{
		if (Input.anyKeyDown) 
		{
			SceneManager.LoadScene("Adventure");
		}
	}
}
