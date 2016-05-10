using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private MountainGamePlayManager mountainGamePlayManager;
    private Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        GameObject mountainGamePlayManagerObject = GameObject.FindWithTag("MonController");
        if (mountainGamePlayManagerObject != null)
        {
            mountainGamePlayManager = mountainGamePlayManagerObject.GetComponent<MountainGamePlayManager>();
        }
        if (mountainGamePlayManager == null)
        {
            Debug.Log("Cannot find 'mountainGamePlayManager' script");
        }
    }

	float speed = 10;
    // Update is called once per frame
    void Update()
    {
        float leftRight = Input.GetAxis("Horizontal");
        transform.Translate(leftRight * Time.deltaTime * speed, 0, 0);
        if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time > 10)
        {
            rb.AddForce(transform.up * 5);
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            ScoreManager.ScoreValue -= 1000;
            Destroy(other.gameObject);
            mountainGamePlayManager.timeTemp -= 3;
        }
        if (other.tag == "Items1")
        {
            Destroy(other.gameObject);
            mountainGamePlayManager.timeTemp += 10;
        }
        if (other.tag == "Medal")
        {
            Destroy(other.gameObject);
            ScoreManager.ScoreValue += 3000;
        }
    }


}
