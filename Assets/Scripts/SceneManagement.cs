using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagement : MonoBehaviour {
	[SerializeField]
	private GameObject stalagmiteBackground;
	[SerializeField]
	private GameObject boss;
	[SerializeField]
	private GameObject player;
	[SerializeField]
	private Camera cam;
	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
		//gameObject.GetComponent<Renderer>().enabled = false;
	}
	
	void Awake() {
		cam.transform.position = Camera.main.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// if (player.activeSelf == false) {
		// 	//gameObject.GetComponent<Renderer>().enabled = true;			
		// }
	}
}
