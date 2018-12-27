using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Rigidbody2D))]
public class Fish : MonoBehaviour {

    
    [SerializeField] float kekuatan_berenang;
    [SerializeField] AudioClip renang;
    [SerializeField] AudioClip nabrak;
    [SerializeField] AudioClip sukses;

    public float rotasi_ikan = 1;
    Rigidbody2D myRigidbody;
    AudioSource[] myAudioSources;
    Quaternion downRotation;
    Quaternion forwardRotation;
    
	
    void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAudioSources = GetComponents<AudioSource>();
        downRotation = Quaternion.Euler(0, 0, -30);
        forwardRotation = Quaternion.Euler(0, 0, 35);
    }
    void Update() {

        if (Input.GetMouseButtonDown(0) && !Game_Manager.instance.gameover)
        {
            Berenang();
            transform.rotation = forwardRotation;
        
           
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, rotasi_ikan * Time.deltaTime);

        

    }
  
   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (Game_Manager.instance.gameover)
            return;
        if (col.CompareTag("sukses"))
        {
            Game_Manager.instance.sukses++;
            Suara(sukses, 1);
            UIManager.instance.Score();
        }
        if (col.CompareTag("pipa"))
        {
            Game_Manager.instance.gameover = true;
            Suara(nabrak,0);
            Game_Manager.instance.GameOver();
            Game_Manager.instance.Play();
            
        }
        
    }
   
	void Berenang () {
       
        Vector3 velocity = myRigidbody.velocity;
        velocity.y = kekuatan_berenang;
        myRigidbody.velocity = velocity;
        Suara(renang,0);
	
    }
    void Suara(AudioClip suarayangdimainkan, int audiosourceID)
    {
        myAudioSources[audiosourceID].clip = suarayangdimainkan;
        myAudioSources[audiosourceID].Play();
    }
}
