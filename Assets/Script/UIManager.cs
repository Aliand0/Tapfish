using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UIManager : MonoBehaviour {

    public static UIManager instance;
    [SerializeField] Text pointText;
    [SerializeField] Animator gameoverAnim;
    [SerializeField] Animator play;
	// Use this for initialization
	void Start () {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
	}
	
	// Update is called once per frame
	public void Score () {
        pointText.text = Game_Manager.instance.sukses.ToString();
	}

    public void ShowGameover(bool show)
    {
        gameoverAnim.SetBool("Show", show);
    }
    public void ShowPlay(bool show)
    {
        play.SetBool("Show", show);
    }
}
