using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour {

    private int nextSceneToLoad;
    private int levelCount;
    private int levelNext;

	// Use this for initialization
	void Start () {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
       // levelNext = SceneManager.GetActiveScene().buildIndex + 1;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D collision) {
      //  SceneManager.LoadScene(nextSceneToLoad);
        SceneManager.LoadScene(1);
	}
}
