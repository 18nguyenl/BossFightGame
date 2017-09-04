using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRight : MonoBehaviour {
    private bool isTochingFloatingPlatform;
    private bool isTouchingMovementArea;
    private Rigidbody2D movement;
    private Animator playerAnimations;
    private CapsuleCollider2D skeleton;
	void Start () {
        movement = gameObject.GetComponent<Rigidbody2D>();
        playerAnimations = gameObject.GetComponent<Animator>();
        skeleton = gameObject.GetComponent<CapsuleCollider2D>();
        isTochingFloatingPlatform = false;
        isTouchingMovementArea = false;
	}
	
	// Update is called once per frame
	void Update () {
        playerAnimations.SetFloat("HorizontalVal", movement.velocity.x);
        //Debug.Log("not moving");
        if ((Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space)) && skeleton.IsTouchingLayers(LayerMask.GetMask("Ground")) && (!isTochingFloatingPlatform || isTouchingMovementArea)) {
            print("I jumped!");
            movement.AddForce(new Vector2(0, 250f));
            playerAnimations.SetFloat("HorizontalVal", movement.velocity.x); 
        } else if((Input.GetKey(KeyCode.D)  || Input.GetKeyDown(KeyCode.D)))
        {
            if (skeleton.IsTouchingLayers(LayerMask.GetMask("Ground")) && (!isTochingFloatingPlatform || isTouchingMovementArea)) {
                movement.AddForce(new Vector2(7.0f, 100.0f));
            } else {
                movement.AddForce(new Vector2(7.0f, 0));
            }
            playerAnimations.SetFloat("HorizontalVal", movement.velocity.x);            
        } else if ((Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.A))) {
            if (skeleton.IsTouchingLayers(LayerMask.GetMask("Ground")) && (!isTochingFloatingPlatform || isTouchingMovementArea)) {
                movement.AddForce(new Vector2(-7.0f, 100.0f));
            } else {
                movement.AddForce(new Vector2(-7.0f, 0));
            }
            playerAnimations.SetFloat("HorizontalVal", movement.velocity.x); 
        }
	}

    void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.tag == "floating platform") {
            isTochingFloatingPlatform = true;
        } else {
            isTochingFloatingPlatform = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.transform.parent.name == "Movement Areas") {
            isTouchingMovementArea = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.transform.parent.name == "Movement Areas") {
            isTouchingMovementArea = false;
        }
    }
}
