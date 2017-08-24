using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRight : MonoBehaviour {
    Rigidbody2D movement;
    Animator playerAnimations;

	// Use this for initialization
	void Start () {
        movement = gameObject.GetComponent<Rigidbody2D>();
        playerAnimations = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetAxis("Horizontal") > 0) 
        {
            movement.AddForce(new Vector2(Input.GetAxis("Horizontal"), 0));
        }
		
	}
}
