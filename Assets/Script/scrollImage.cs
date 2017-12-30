using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollImage : MonoBehaviour {
	float scrollSpeed;
	Vector2 startPos;
	// Use this for initialization
	void Start () {
		scrollSpeed = -0.2f;
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		scrollSpeed -= Time.deltaTime*0.1;
		float newPos = Mathf.Repeat(Time.time * scrollSpeed,50);
		transform.position = startPos + Vector2.down * newPos;
	}
}
