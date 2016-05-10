using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MinigameMenuManager : MonoBehaviour 

{
	public Text difText;
	public Image star1,star2,star3;
	public Sprite conStar,emptyStar;
	static int stage;
	static int dif;
	public GameObject menuMini;
	static int starValueEasyOld,starValueNormalOld,starValueHardOld;
	static int starValueEasy,starValueNormal,starValueHard;
	public AudioSource audioSource;

	void Awake()
	{
		ScoreManager.ScoreValue = 0;
		Time.timeScale = 0;
		dif = 0;
		stage = PlayerPrefs.GetInt ("Stage");
	}
	void Update()
	{
		if (stage == 1) 
		{
			if (dif == 0) 
			{
				PlayerPrefs.SetInt ("Dif", dif);
				difText.text = "Easy";
				starValueEasy = PlayerPrefs.GetInt ("starValueEasyCave");
				if (starValueEasyOld < starValueEasy) 
				{
					starValueEasyOld = starValueEasy;
				}

				if (starValueEasyOld == 1) 
				{
					star1.sprite = conStar;
				}
				else if (starValueEasyOld == 2) 
				{
					star1.sprite = conStar;
					star2.sprite = conStar;
				}
				else if (starValueEasyOld == 3) 
				{
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;
				}
				else
				{
					star1.sprite = emptyStar;
					star2.sprite = emptyStar;
					star3.sprite = emptyStar;
				}
			} 
			else if (dif == 1) 
			{
				PlayerPrefs.SetInt ("Dif", dif);
				difText.text = "Normal";
				starValueNormal = PlayerPrefs.GetInt ("starValueNormalCave");
				if (starValueNormalOld < starValueEasy) 
				{
					starValueNormalOld = starValueNormal;
				}
				if (starValueNormalOld == 1) 
				{
					star1.sprite = conStar;
				}
				else if (starValueNormalOld == 2) 
				{
					star1.sprite = conStar;
					star2.sprite = conStar;
				}
				else if (starValueNormalOld == 3) 
				{
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;
				}
				else
				{
					star1.sprite = emptyStar;
					star2.sprite = emptyStar;
					star3.sprite = emptyStar;
				}	
			} 
			else 
			{
				PlayerPrefs.SetInt ("Dif", dif);
				difText.text = "Hard";
				starValueHard = PlayerPrefs.GetInt ("starValueHardCave");
				if (starValueHardOld < starValueHard) 
				{
					starValueHardOld = starValueHard;
				}
				if (starValueHardOld == 1) 
				{
					star1.sprite = conStar;
				}
				else if (starValueHardOld == 2) 
				{
					star1.sprite = conStar;
					star2.sprite = conStar;
				}
				else if (starValueHardOld == 3) 
				{
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;
				}
				else
				{
					star1.sprite = emptyStar;
					star2.sprite = emptyStar;
					star3.sprite = emptyStar;
				}	
			}
		}
		else if (stage == 2)
		{
		if (dif == 0) 
		{
			PlayerPrefs.SetInt ("Dif", dif);
			difText.text = "Easy";
			starValueEasy = PlayerPrefs.GetInt ("starValueEasyRiver");
			if (starValueEasyOld < starValueEasy) 
			{
				starValueEasyOld = starValueEasy;
			}

			if (starValueEasyOld == 1) 
			{
				star1.sprite = conStar;
			}
			else if (starValueEasyOld == 2) 
			{
				star1.sprite = conStar;
				star2.sprite = conStar;
			}
			else if (starValueEasyOld == 3) 
			{
				star1.sprite = conStar;
				star2.sprite = conStar;
				star3.sprite = conStar;
			}
			else
			{
				star1.sprite = emptyStar;
				star2.sprite = emptyStar;
				star3.sprite = emptyStar;
			}
		} 
		else if (dif == 1) 
		{
			PlayerPrefs.SetInt ("Dif", dif);
			difText.text = "Normal";
			starValueNormal = PlayerPrefs.GetInt ("starValueNormalRiver");
			if (starValueNormalOld < starValueEasy) 
			{
				starValueNormalOld = starValueNormal;
			}
			if (starValueNormalOld == 1) 
			{
				star1.sprite = conStar;
			}
			else if (starValueNormalOld == 2) 
			{
				star1.sprite = conStar;
				star2.sprite = conStar;
			}
			else if (starValueNormalOld == 3) 
			{
				star1.sprite = conStar;
				star2.sprite = conStar;
				star3.sprite = conStar;
			}
			else
			{
				star1.sprite = emptyStar;
				star2.sprite = emptyStar;
				star3.sprite = emptyStar;
			}	
		} 
		else 
		{
			PlayerPrefs.SetInt ("Dif", dif);
			difText.text = "Hard";
			starValueHard = PlayerPrefs.GetInt ("starValueHardRiver");
			if (starValueHardOld < starValueHard) 
			{
				starValueHardOld = starValueHard;
			}
			if (starValueHardOld == 1) 
			{
				star1.sprite = conStar;
			}
			else if (starValueHardOld == 2) 
			{
				star1.sprite = conStar;
				star2.sprite = conStar;
			}
			else if (starValueHardOld == 3) 
			{
				star1.sprite = conStar;
				star2.sprite = conStar;
				star3.sprite = conStar;
			}
			else
			{
				star1.sprite = emptyStar;
				star2.sprite = emptyStar;
				star3.sprite = emptyStar;
			}	
		}
		}
	}
	public void StartGame()
	{
		menuMini.SetActive (false);
		Time.timeScale = 1;
		//audioSource.Play ();
	}
	public void NextDif()
	{
		if (dif < 2) 
		{
			dif += 1;
		} 
		else 
		{
			dif = 0;
		}
	}
	public void PreviousDif()
	{
		if (dif > 0 ) 
		{
			dif -= 1;
		} 
		else 
		{
			dif = 2;
		}
	}
	public void BackToAdventure()
	{
		SceneManager.LoadScene ("Adventure");
	}
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel); ;
    }
}
