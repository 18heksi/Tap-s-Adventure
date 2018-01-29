using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject theEnemy;
    public Transform generationPoint;
    public float distanceBetween;

    private float enemyWidth;

	// Use this for initialization
	void Start () {
        enemyWidth = theEnemy.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + enemyWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(theEnemy, transform.position, transform.rotation);
        }
	}
}
