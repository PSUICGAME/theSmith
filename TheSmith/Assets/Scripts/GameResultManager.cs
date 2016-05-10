using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameResultManager : MonoBehaviour 

{
	static int stage;
	static int dif;
	static int starValueEasy,starValueNormal,starValueHard;
	public Image star1, star2, star3;
	public Sprite conStar,emptyStar;
	public AudioSource audioSource;

	public void Retry()
	{
		if (stage == 0) 
		{
			SceneManager.LoadScene ("ForestGame");
		}

		else if (stage == 1) 
		{
			SceneManager.LoadScene ("CaveGame");
		}

		else if (stage == 2) 
		{
			SceneManager.LoadScene ("RiverGame");
		}

		else
		{
			SceneManager.LoadScene ("MoutainGame");
		}
	}
	public void MainMenu()
	{
		SceneManager.LoadScene ("Adventure");
	}

	void Start()
	{
		dif = PlayerPrefs.GetInt ("Dif");
		stage = PlayerPrefs.GetInt ("Stage");
	}

	void Update()
	{
		if (stage == 0) {
			if (dif == 0) {
				if (ScoreManager.ScoreValue >= 11000) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;

					starValueEasy = 3;
					PlayerPrefs.SetInt ("starValueEasyForest", starValueEasy);
				} else if (ScoreManager.ScoreValue >= 9500) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					starValueEasy = 2;
					PlayerPrefs.SetInt ("starValueEasyForest", starValueEasy);
				} else if (ScoreManager.ScoreValue >= 8000) {
					star1.sprite = conStar;
					starValueEasy = 1;
					PlayerPrefs.SetInt ("starValueEasyForest", starValueEasy);
				} else {
					starValueEasy = 0;
					PlayerPrefs.SetInt ("starValueEasyForest", starValueEasy);
				}
			} else if (dif == 1) {
				if (ScoreManager.ScoreValue >= 9500) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;

					starValueNormal = 3;
					PlayerPrefs.SetInt ("starValueNormalForest", starValueNormal);
				} else if (ScoreManager.ScoreValue >= 8000) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					starValueNormal = 2;
					PlayerPrefs.SetInt ("starValueNormalForest", starValueNormal);
				} else if (ScoreManager.ScoreValue >= 6500) {
					star1.sprite = conStar;
					starValueNormal = 1;
					PlayerPrefs.SetInt ("starValueNormalForest", starValueNormal);
				} else {
					starValueNormal = 0;
					PlayerPrefs.SetInt ("starValueNormalForest", starValueNormal);
				}
			} else {
				if (ScoreManager.ScoreValue >= 8000) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;

					starValueHard = 3;
					PlayerPrefs.SetInt ("starValueHardForest", starValueHard);
				} else if (ScoreManager.ScoreValue >= 6500) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					starValueHard = 2;
					PlayerPrefs.SetInt ("starValueHardForest", starValueHard);
				} else if (ScoreManager.ScoreValue >= 4000) {
					star1.sprite = conStar;
					starValueHard = 1;
					PlayerPrefs.SetInt ("starValueHardForest", starValueHard);
				} else {
					starValueHard = 0;
					PlayerPrefs.SetInt ("starValueHardForest", starValueHard);
				}
			}
		}
		else if (stage == 1) {
			if (dif == 0) {
				if (ScoreManager.ScoreValue >= 4750) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;

					starValueEasy = 3;
					PlayerPrefs.SetInt ("starValueEasyCave", starValueEasy);
				} else if (ScoreManager.ScoreValue >= 3750) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					starValueEasy = 2;
					PlayerPrefs.SetInt ("starValueEasyCave", starValueEasy);
				} else if (ScoreManager.ScoreValue >= 2750) {
					star1.sprite = conStar;
					starValueEasy = 1;
					PlayerPrefs.SetInt ("starValueEasyCave", starValueEasy);
				} else {
					starValueEasy = 0;
					PlayerPrefs.SetInt ("starValueEasyCave", starValueEasy);
				}
			} else if (dif == 1) {
				if (ScoreManager.ScoreValue >= 3750) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;

					starValueNormal = 3;
					PlayerPrefs.SetInt ("starValueNormalCave", starValueNormal);
				} else if (ScoreManager.ScoreValue >= 2750) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					starValueNormal = 2;
					PlayerPrefs.SetInt ("starValueNormalCave", starValueNormal);
				} else if (ScoreManager.ScoreValue >= 1750) {
					star1.sprite = conStar;
					starValueNormal = 1;
					PlayerPrefs.SetInt ("starValueNormalCave", starValueNormal);
				} else {
					starValueNormal = 0;
					PlayerPrefs.SetInt ("starValueNormalCave", starValueNormal);
				}
			} else {
				if (ScoreManager.ScoreValue >= 2750) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;

					starValueHard = 3;
					PlayerPrefs.SetInt ("starValueHardCave", starValueHard);
				} else if (ScoreManager.ScoreValue >= 1750) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					starValueHard = 2;
					PlayerPrefs.SetInt ("starValueHardCave", starValueHard);
				} else if (ScoreManager.ScoreValue >= 750) {
					star1.sprite = conStar;
					starValueHard = 1;
					PlayerPrefs.SetInt ("starValueHardCave", starValueHard);
				} else {
					starValueHard = 0;
					PlayerPrefs.SetInt ("starValueHardCave", starValueHard);
				}
			}
		}

		else if (stage == 2) {
			if (dif == 0) {
				if (ScoreManager.ScoreValue >= 7000) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;

					starValueEasy = 3;
					PlayerPrefs.SetInt ("starValueEasyRiver", starValueEasy);
				} else if (ScoreManager.ScoreValue >= 6000) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					starValueEasy = 2;
					PlayerPrefs.SetInt ("starValueEasyRiver", starValueEasy);
				} else if (ScoreManager.ScoreValue >= 5000) {
					star1.sprite = conStar;
					starValueEasy = 1;
					PlayerPrefs.SetInt ("starValueEasyRiver", starValueEasy);
				} else {
					starValueEasy = 0;
					PlayerPrefs.SetInt ("starValueEasyRiver", starValueEasy);
				}
			} else if (dif == 1) {
				if (ScoreManager.ScoreValue >= 6000) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;

					starValueNormal = 3;
					PlayerPrefs.SetInt ("starValueNormalRiver", starValueNormal);
				} else if (ScoreManager.ScoreValue >= 5000) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					starValueNormal = 2;
					PlayerPrefs.SetInt ("starValueNormalRiver", starValueNormal);
				} else if (ScoreManager.ScoreValue >= 4000) {
					star1.sprite = conStar;
					starValueNormal = 1;
					PlayerPrefs.SetInt ("starValueNormalRiver", starValueNormal);
				} else {
					starValueNormal = 0;
					PlayerPrefs.SetInt ("starValueNormalRiver", starValueNormal);
				}
			} else {
				if (ScoreManager.ScoreValue >= 5000) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					star3.sprite = conStar;

					starValueHard = 3;
					PlayerPrefs.SetInt ("starValueHardRiver", starValueHard);
				} else if (ScoreManager.ScoreValue >= 4000) {
					star1.sprite = conStar;
					star2.sprite = conStar;
					starValueHard = 2;
					PlayerPrefs.SetInt ("starValueHardRiver", starValueHard);
				} else if (ScoreManager.ScoreValue >= 3000) {
					star1.sprite = conStar;
					starValueHard = 1;
					PlayerPrefs.SetInt ("starValueHardRiver", starValueHard);
				} else {
					starValueHard = 0;
					PlayerPrefs.SetInt ("starValueHardRiver", starValueHard);
				}
			}
		}
	}
}
