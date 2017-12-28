using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerometer : MonoBehaviour {
	
	bool leafshake;
	Vector3 leaf;
	// Use this for initialization
	private float leafShakeSpeed = 0.0f;
	void Start () {
		leafshake = true;
		leaf = GameObject.Find("leaf").transform.position;
		
		//check if we have an accelerometer
		if(SystemInfo.supportsAccelerometer)
		{
			
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		
		//key input and move gameObject
		/*
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
		*/
		AccelerometerMove();
		
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
	
	void AccelerometerMove(){	
		float x = Input.acceleration.x;
		if(x<-0.1f)
		{
			MoveLeft();
		}
		else if(x>0.1f)
		{
			MoveRight();
		}
		else
		{
			setVelocityZero();
		}
	}
	
	void MoveLeft(){
		gameObject.transform.position += new Vector3(-0.1f,0,0);
		transform.Rotate(0,0,-15f); 
	}
	
	void MoveRight(){
		gameObject.transform.position += new Vector3(0.1f,0,0);
		transform.Rotate(0,0,15f);
    }
}
