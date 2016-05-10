using UnityEngine;
using System.Collections;

public class MountainGamePlayManager : MonoBehaviour {

	public GameObject[] RockPrefabs;
	public GameObject panelResult;

	public GameObject GoldcoinPrefabs;
    public GameObject TimeUpPrefabs;
    // Use this for initialization
    void Start () {
		panelResult.SetActive(false);
		InvokeRepeating("generateObstacle",0.5f,0.5f);
		InvokeRepeating("generateGoldMedal",2.0f,2.0f);
        InvokeRepeating("generateTimeUp", 20.0f, 20.0f);
        
    }

	void generateObstacle()
	{
		float xRandom = Random.Range(-4.2f,4.2f);
        GameObject rock = RockPrefabs[Random.Range(0, RockPrefabs.Length)];
        Instantiate (rock, new Vector3(xRandom, 0.5f ,30),Quaternion.identity) ;
		//Destroy(clonerock,30.0f);
	}

	void generateGoldMedal()
	{
		float xRandom = Random.Range(-4.2f,4.2f);

		GameObject cloneGoldenMedal = Instantiate( GoldcoinPrefabs,
			new Vector3(xRandom, 0.5f ,30),
			Quaternion.identity) as GameObject;
		Destroy(cloneGoldenMedal,30.0f);
	}
    void generateTimeUp()
    {
        float xRandom = Random.Range(-4.2f, 4.2f);

        GameObject cloneTimeUp = Instantiate(TimeUpPrefabs,
            new Vector3(xRandom, 0.5f, 30),
            Quaternion.identity) as GameObject;
        Destroy(cloneTimeUp, 30.0f);
    }

    public float timeTemp = 30;
	// Update is called once per frame
	void Update () {


		timeTemp = timeTemp - Time.deltaTime;
		TimeManager.timeValue = (int)timeTemp;

		if(TimeManager.timeValue < 1)
		{
			calculateStone();
			panelResult.SetActive(true);
			Time.timeScale = 0;
		}

	}

	void calculateStone()
	{
		if( ScoreManager.ScoreValue < 4500)
		{
			// get 1 stone
			PlayerPrefs.SetInt("mStone",2); 
		}
		else if( ScoreManager.ScoreValue < 6000)
		{
			// get 2 stones
			PlayerPrefs.SetInt("mStone",1);
		}
		else
		{

		}
	}
}
