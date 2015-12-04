﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public float distanceModifier;

    public static float distance = 0;

	// Use this for initialization
	void Start () {
        scoreText.text = "0";
    }
	
	// Update is called once per frame
	void Update () {
        distance = Camera.main.transform.position[0] * distanceModifier * PlayerController.scoreCoeficient;
        scoreText.text = "" + (int)distance;
	}
}
