﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollImage : MonoBehaviour {
	float scrollSpeed = -2f;
	Vector2 startPos;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float newPos = Mathf.Repeat(Time.time * scrollSpeed,50);
		transform.position = startPos + Vector2.down * newPos;
	}
}
