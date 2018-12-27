using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {
    public GameObject buble;
    public Vector2 velocity;
    bool shoot = true;
    public Vector2 offset = new Vector2(0.4f, 0.1f);
    public float cooldown = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && shoot)
        {
            GameObject go = (GameObject)Instantiate(buble, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);
            go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x, velocity.y);
        }
	}
    IEnumerator Canshoot()
    {
        shoot = false;
        yield return new WaitForSeconds(cooldown);
        shoot = true;
    }
}
