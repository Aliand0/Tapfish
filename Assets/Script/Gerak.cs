using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerak : MonoBehaviour
{
    float bataskirikamera;
    float setlebar;

    void Start() {
        bataskirikamera = Camera.main.transform.position.x - Camera.main.orthographicSize * Camera.main.aspect;
        setlebar = GetComponent<SpriteRenderer>().bounds.size.x/2f;
    }
    void Update() {
        if (Game_Manager.instance.gameover)
            return;
        if(transform.position.x <= bataskirikamera - setlebar)
            transform.Translate(Vector3.right*((setlebar*4f)-0.04f));

        transform.Translate(Vector3.left * Game_Manager.instance.kecepatan * Time.deltaTime);
    }
}