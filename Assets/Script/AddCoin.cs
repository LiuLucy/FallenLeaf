﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCoin : MonoBehaviour
{
    // Use this for initialization
    public Text score_Coin;
    private int score_Count = 0;
    private GameObject coin;
    private GameObject loveHealth;
    void Start()
    {
        score_Coin.text = score_Count.ToString();
        score_Coin.text = PlayerPrefs.GetInt("Record").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        coin = GameObject.FindGameObjectWithTag("coin");
        loveHealth = GameObject.FindGameObjectWithTag("love");
        Destroy(coin, 5);
        Destroy(loveHealth, 5);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "coin")
        {
            score_Count += 1;
            score_Coin.text = score_Count.ToString();
            PlayerPrefs.SetInt("Record", score_Count);
            Destroy(other.gameObject);
        }
    }
}
