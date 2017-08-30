using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRight : MonoBehaviour {
    Rigidbody2D movement;
    Animator playerAnimations;
    CapsuleCollider2D skeleton;
	void Start () {
        movement = gameObject.GetComponent<Rigidbody2D>();
        playerAnimations = gameObject.GetComponent<Animator>();
        skeleton = gameObject.GetComponent<CapsuleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        playerAnimations.SetFloat("HorizontalVal", movement.velocity.x);
        Debug.Log("not moving");
        if ((Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space)) && skeleton.IsTouchingLayers()) {
            movement.AddForce(new Vector2(0, 200f));
            playerAnimations.SetFloat("HorizontalVal", movement.velocity.x); 
        } else if((Input.GetKey(KeyCode.D)  || Input.GetKeyDown(KeyCode.D)))
        {
            if (skeleton.IsTouchingLayers()) {
                movement.AddForce(new Vector2(7.0f, 100.0f));
            } else {
                movement.AddForce(new Vector2(7.0f, 0));
            }
            playerAnimations.SetFloat("HorizontalVal", movement.velocity.x);            
        } else if ((Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.A))) {
            if (skeleton.IsTouchingLayers()) {
                movement.AddForce(new Vector2(-7.0f, 100.0f));
            } else {
                movement.AddForce(new Vector2(-7.0f, 0));
            }
            playerAnimations.SetFloat("HorizontalVal", movement.velocity.x); 
        }
	}

    public void OnCollisionEnter2D (Collision2D collision) {
        
    }
}
