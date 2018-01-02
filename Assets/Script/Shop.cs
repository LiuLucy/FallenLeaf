using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour {
	public  GameObject leafS;
	private Sprite leaftSkin;
	public Sprite[] leaf_Skin;
	private string[] leafI;
	public SpriteRenderer leaf_img;
	private int skin_int = 0;
 	// Use this for initialization
	void Start () {
		leaftSkin = leafS.gameObject.GetComponent<SpriteRenderer>().sprite;		
	}
	
	// Update is called once per frame
	void Update () {
		if(skin_int == leafI.Length)
		{
			skin_int = 0;
			leaf_img.sprite = leaf_Skin[skin_int];
			
		}
		if(skin_int < 0)
		{
			skin_int = leafI.Length - 1;
			leaf_img.sprite = leaf_Skin[skin_int];
		}
		
	}
	public void selectRight()
	{
		skin_int = skin_int+1;
		leaf_img.sprite = leaf_Skin[skin_int];
		leafS.gameObject.GetComponent<SpriteRenderer>().sprite = leaf_Skin[skin_int];
		Debug.Log(skin_int);
	}
	public void selectLeft()
	{
		skin_int = skin_int-1;
		leaf_img.sprite = leaf_Skin[skin_int];
		leafS.gameObject.GetComponent<SpriteRenderer>().sprite = leaf_Skin[skin_int];
		Debug.Log(skin_int);
	}
	public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
