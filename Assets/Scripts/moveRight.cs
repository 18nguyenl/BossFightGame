using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRight : MonoBehaviour {
    Rigidbody2D movement;
    Animator playerAnimations;
    CapsuleCollider2D skeleton;

	// Use this for initialization
	void Start () {
        movement = gameObject.GetComponent<Rigidbody2D>();
        playerAnimations = gameObject.GetComponent<Animator>();
        skeleton = gameObject.GetComponent<CapsuleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        playerAnimations.SetFloat("HorizontalVal", movement.velocity.x);
        Debug.Log("not moving");
        if((Input.GetKey(KeyCode.D)  || Input.GetKeyDown(KeyCode.D)) && skeleton.IsTouchingLayers())
        {
            movement.velocity = new Vector2(3.0f, 25.0f);
            playerAnimations.SetFloat("HorizontalVal", movement.velocity.x);            
        } else if ((Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space)) && skeleton.IsTouchingLayers()) {
            movement.velocity = new Vector2(0, 50f);
            playerAnimations.SetFloat("HorizontalVal", movement.velocity.x); 
        } else if ((Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.A)) && skeleton.IsTouchingLayers()) {
            movement.velocity = new Vector2(-3.0f, 25.0f);
            playerAnimations.SetFloat("HorizontalVal", movement.velocity.x); 
        }
		
	}

    public void OnCollisionEnter2D (Collision2D collision) {
        
    }
}
