using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leafController : MonoBehaviour {
	
	bool leafshake;
	Vector3 leaf;
    private float speed;
    // Use this for initialization
    private float leafShakeSpeed = 0.0f;
	void Start ()
    {
        speed = 5.0f;
        leafshake = true;
		leaf = GameObject.Find("leaf").transform.position;
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y > 33)
            transform.position += Vector3.down * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))
		{
			gameObject.transform.position += new Vector3(0.1f,0,0);
			transform.Rotate(0,0,15f); 
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			gameObject.transform.position += new Vector3(-0.1f,0,0);
			transform.Rotate(0,0,-15f); 
			
		}
		
		if(transform.localRotation.z > 0.4f)
		{
			leafshake = true;
		}
		if(transform.localRotation.z < -0.4)
		{
			leafshake = false;
		}
		
		if(leafshake)
		{
			transform.RotateAround(leaf,Vector3.forward,0.5f);
		}
		else
		{
			transform.RotateAround(leaf,Vector3.forward,-0.5f);
		}
	}
}
