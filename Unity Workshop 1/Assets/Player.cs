using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speedy = 5f;
	public float speedx = 5f;
	Rigidbody2D body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)){
			body.AddForce (new Vector2 (0f, speedy));
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			body.AddForce (new Vector2 (0f, -speedy));
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			body.AddForce (new Vector2 (speedx, 0f));
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			body.AddForce (new Vector2 (-speedx, 0f));
		}
	}
}
