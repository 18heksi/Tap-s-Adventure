using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public PlayerController thePlayer;

    private Vector3 lastPlayerPotition;
    private float distanceToMove;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPotition = thePlayer.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        distanceToMove = thePlayer.transform.position.x - lastPlayerPotition.x;

        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);

        lastPlayerPotition = thePlayer.transform.position;
	}
}
