using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rintangan : MonoBehaviour
{
    float bataskirikamera;
    float bataskanankamera;
    float setlebar;

    void Start() {
        bataskirikamera = Camera.main.transform.position.x - Camera.main.orthographicSize * Camera.main.aspect;
        bataskanankamera = Camera.main.transform.position.x + Camera.main.orthographicSize * Camera.main.aspect;
        setlebar = GetComponentInChildren<SpriteRenderer>().bounds.size.x/2f;
        transform.position = ((Vector3.right * transform.position.x) + (Vector3.up * Random.Range(Game_Manager.instance.mintinggi, Game_Manager.instance.maxtinggi)));
    }
    void Update() {
        if (Game_Manager.instance.gameover)
            return;
        if (transform.position.x <= bataskirikamera - 20*setlebar)
            transform.position = ((Vector3.right*(bataskanankamera - (14*setlebar))) + (Vector3.up * Random.Range(Game_Manager.instance.mintinggi, Game_Manager.instance.maxtinggi)));

        transform.Translate(Vector3.left * Game_Manager.instance.kecepatan * Time.deltaTime);
    }
}
