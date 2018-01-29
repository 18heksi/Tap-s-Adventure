using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform enemyGenerator;
    private Vector3 enemyStartPoint;

    public PlayerController thePlayer;
    private Vector3 playerStartPoint;
    private ScoreManager theScoreManager;

    public DeathMenu theDeathScreen;

    // Use this for initialization
    void Start () {
        enemyStartPoint = enemyGenerator.position;
        playerStartPoint = thePlayer.transform.position;
        theScoreManager = FindObjectOfType<ScoreManager>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void RestartGame()
    {

        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive((false));

        theDeathScreen.gameObject.SetActive(true);

        //StartCoroutine("RestartGameCo");
    }

    public void Reset()
    {
        thePlayer.transform.position = playerStartPoint;
        enemyGenerator.position = enemyStartPoint;
        thePlayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }

    /*public IEnumerable RestartGameCo()
    {
        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive((false));
        yield return new WaitForSeconds(0.5f);
        thePlayer.transform.position = playerStartPoint;
        enemyGenerator.position = enemyStartPoint;
        thePlayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }*/
}
