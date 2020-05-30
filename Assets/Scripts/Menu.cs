using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	public void PlayGame() {
        SceneManager.LoadScene(2);
	}

    public void QuitGame()
    {
        Application.Quit();
    }
	

}
