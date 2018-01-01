using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour {

    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }
    public Slider healthbar;
    public Image currentHealthBar;


    // Use this for initialization
    void Start () {
        //初始化 總血量 目前血量 血條
        MaxHealth = 100f;
        CurrentHealth = MaxHealth;
        healthbar.value = CalculateHealth();
    }
	
	// Update is called once per frame
	void Update () {
        //測試用，點擊x 血量扣1
        if (Input.GetKeyDown(KeyCode.X))
        {
            DealDamage(1);
            Debug.Log("health -1");
        }
	}

    void DealDamage(float damageValue)
    {
        CurrentHealth -= damageValue;

        healthbar.value = CalculateHealth();
        ChangeColor();
        if (CurrentHealth <= 0)
            Die();
    }
     void LoveHealth(float LoveValue)
    {
        CurrentHealth += LoveValue;

        healthbar.value = CalculateHealth();
        ChangeColor();
        
    }
    
    void ChangeColor()
    {

        //改變樹葉顏色
        float currentleafColor = (CurrentHealth * 0.35f) / 100f + 0.15f;
        GetComponent<SpriteRenderer>().color = Color.HSVToRGB(currentleafColor, 1, 1);

        //改變血條顏色
        float currentHealthColor = (CurrentHealth * 0.5f) / 100f - 0.17f;
        if (currentHealthColor < 0.02f) currentHealthColor = 0.02f;
        currentHealthBar.color = Color.HSVToRGB(currentHealthColor, 1, 1);

    }
    float CalculateHealth()
    {
        //回傳現在血量
        return CurrentHealth / MaxHealth;

    }

    void Die()
    {
        CurrentHealth = 0;
        Debug.Log("you death");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "TreeBranch")
        {
            DealDamage(10);
        }
        if (other.gameObject.tag == "enemy")
        {
            DealDamage(40);
        }
        if (other.gameObject.tag == "love")
        {
            Debug.Log("love");
            Destroy(other.gameObject);
            LoveHealth(7);
        }
    }
}
