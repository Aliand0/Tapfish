using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour {
	// Use this for initialization
	public void PlayGame () {      
        SceneManager.LoadScene(1);        
	}
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
   
}
