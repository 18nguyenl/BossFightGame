using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpdater : MonoBehaviour {
	private Text scoreContent;  
	// Use this for initialization
	void Start () {
		scoreContent = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreContent.text = "Score: " + ScoreManagement.score;
	}
}
