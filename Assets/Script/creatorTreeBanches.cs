using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatorTreeBanches : MonoBehaviour {

	public GameObject treeBanches1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate(treeBanches1,new Vector3(Random.Range(-12.5f,-13f),Random.Range(-40.0f,60.0f),0f),treeBanches1.transform.rotation);
	}
}
