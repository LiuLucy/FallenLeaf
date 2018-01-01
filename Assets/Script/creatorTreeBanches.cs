using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatorTreeBanches : MonoBehaviour {

	public GameObject treeBanches1;
	public GameObject loveHealth;
	// Use this for initialization
	void Start () {
		InvokeRepeating("createGoldleaf",0f,3f);
		InvokeRepeating("createhealth",0f,4f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void createGoldleaf()
	{
		GameObject leafG = Instantiate(treeBanches1,new Vector3(Random.Range(-2f,2f),Random.Range(30.0f,-17.0f),0f),treeBanches1.transform.rotation);
		leafG.transform.parent = GameObject.Find("create").transform;
	}
	private void createhealth()
	{
		GameObject love = Instantiate(loveHealth,new Vector3(Random.Range(-2f,2f),Random.Range(30.0f,-17.0f),0f),loveHealth.transform.rotation);
		love.transform.parent = GameObject.Find("create").transform;
	}
}
