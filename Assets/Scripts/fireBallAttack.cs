using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallAttack : MonoBehaviour {
	[SerializeField]
	private GameObject fire;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 create = new Vector3(Random.Range(transform.position.x - 10, transform.position.x + 10),
                    Random.Range(transform.position.y - 10, transform.position.y + 10), 0f);
		if (Random.Range(1, 50) == 5) {
			Instantiate(fire, create, Quaternion.identity);
		}
	}
}
