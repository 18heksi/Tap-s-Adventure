using System.Collections;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public string playGameLevel;

	public void PlayGame()
    {
        Application.LoadLevel(playGameLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        
    }

}
