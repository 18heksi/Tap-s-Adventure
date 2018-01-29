using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public PlayerController player;
    public DeathMenu theDeathScreen;

    void OnTriggerEnter2D(Collider2D hit)
    {

        if (hit.CompareTag("jatuh"))
        {
            //Application.LoadLevel(1);
            player.gameObject.SetActive(false);
            theDeathScreen.gameObject.SetActive(true);
        }

    }
}