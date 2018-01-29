using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPoints : MonoBehaviour {

    public int scoreToGive;

    private ScoreManager theScoreManager;

	void Start () {
        theScoreManager = FindObjectOfType<ScoreManager>();
	}
	
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "player")
        {
            theScoreManager.AddScore(scoreToGive);
            gameObject.SetActive(false);
        }
    }
}
