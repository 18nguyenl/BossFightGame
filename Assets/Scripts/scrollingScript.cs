using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.Space)) {
			ScrollLeft();
		} else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.Space)) {
			ScrollRight();
		}
	}
	
	void ScrollLeft() {
		transform.position = new Vector2(transform.position.x  - .2f, 0);
	}

	void ScrollRight() {
		transform.position = new Vector2(transform.position.x  + .2f, 0);
	}
}
