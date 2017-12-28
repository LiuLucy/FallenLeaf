using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCoin : MonoBehaviour {
	// Use this for initialization
	public Text score_Coin;
	private int score_Count = 0;
	private GameObject coin;
	void Start () {
		score_Coin.text = score_Count.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
		coin = GameObject.FindGameObjectWithTag("coin");
		Destroy(coin,5);
	}
	 void OnTriggerEnter2D(Collider2D other) {
		 Debug.Log("123");
        if(other.gameObject.tag == "coin")
		{
			score_Count+=1;
			score_Coin.text = score_Count.ToString();
			Debug.Log(score_Count);
			Destroy(other.gameObject);
		}
    }
}
