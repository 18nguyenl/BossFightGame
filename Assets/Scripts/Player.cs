using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private Rigidbody2D body;
	
	public int health { get; set; }
	// Use this for initialization
	void Start () {
		body = gameObject.GetComponent<Rigidbody2D>();
		health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		print(health);
		ScoreManagement.score += health;
		if (health < 0) {
			GameObject.Find("Stalagmite Background").SetActive(false);
			gameObject.SetActive(false);
		}
		if (health < 93) {
			if (Random.Range(1, 100) == 5) {
				health += Random.Range(5, 7);
			}
		}
	}

	void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.tag == "enemy attack") {
			health -= 20;
			body.velocity = body.velocity + new Vector2(-20f, 5f);
			Destroy(collision.gameObject);
		}
    }
	
	void OnParticleCollision(GameObject other) {
		print("flameball collided");
		if (other.tag == "enemy attack") {
			health -= 20;
			ScoreManagement.score -= 300;
			body.velocity = body.velocity + new Vector2(-20f, 5f);
			Destroy(other);
		}
	}

	void OnDestroy() {
		GameObject.Find("Game Over").SetActive(true);
	}
}
