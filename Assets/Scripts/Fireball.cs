using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {
	private Vector3 position;
	[SerializeField]
	private ParticleSystem burst;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + new Vector3(-.3f, 0, 0);
	}

	void OnParticleCollison(GameObject other) {
		position = other.transform.position;
	}

	void OnDestroy() {
		Destroy(Instantiate(burst, transform.position, Quaternion.identity), 1.0f);
	}
}
