using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			ScrollLeft();
		} else if (Input.GetKey(KeyCode.D)) {
			ScrollRight();
		}
	}
	
	void ScrollLeft() {
		transform.position = new Vector2(transform.position.x  + Camera.main.velocity.x / 12, 0);
	}

	void ScrollRight() {
		transform.position = new Vector2(transform.position.x  + Camera.main.velocity.x / 12, 0);
	}
}
