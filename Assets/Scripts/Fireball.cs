using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D body;
	void Start () {
		Destroy(gameObject, 5.0f);
		body = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + new Vector3(-.3f, 0, 0);
	}
}
