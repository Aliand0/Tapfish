using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour {

    public static Game_Manager instance;
    public float kecepatan;
    public float maxtinggi;
    public float mintinggi;
    public bool gameover=false;
    public int sukses;
	void Start () {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
		
	}

    public void GameOver()
    {
        UIManager.instance.ShowGameover(true);
       
    }
    public void Play()
    {
        UIManager.instance.ShowPlay(true);
    }


	
}
