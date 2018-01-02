using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour {
	private  GameObject leafS;
	private Sprite leaftSkin;
	public Sprite[] leaf_Skin;
	private string[] leafI;
	public SpriteRenderer leaf_img;
	private int skin_int = 0;
    // Use this for initialization
    void Start () {
        leafS = (GameObject)Resources.Load("leaf", typeof(GameObject));
        //leafS = GameObject.FindGameObjectWithTag("leaf");
        leaftSkin = leafS.GetComponent<SpriteRenderer>().sprite;

        Debug.Log(leaf_Skin.Length);
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void SelectRight()
	{
		skin_int = skin_int+1;
		if(skin_int == leaf_Skin.Length)
		{
			skin_int = 0;
			leaf_img.sprite = leaf_Skin[skin_int];
			
		}
		if(skin_int < 0)
		{
			skin_int = leafI.Length - 1;
			leaf_img.sprite = leaf_Skin[skin_int];
		}
		
		leaf_img.sprite = leaf_Skin[skin_int];
        leafS.GetComponent<SpriteRenderer>().sprite = leaf_Skin[skin_int];
	
	}
	public void SelectLeft()
	{
		skin_int = skin_int-1;
		if(skin_int == leaf_Skin.Length)
		{
			skin_int = 0;
			leaf_img.sprite = leaf_Skin[skin_int];
			
		}
		if(skin_int < 0)
		{
			skin_int = leaf_Skin.Length - 1;
			leaf_img.sprite = leaf_Skin[skin_int];
		}
		leaf_img.sprite = leaf_Skin[skin_int];
        leafS.GetComponent<SpriteRenderer>().sprite = leaf_Skin[skin_int];
	}
	public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
