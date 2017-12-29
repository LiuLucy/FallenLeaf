using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public UnityEngine.UI.Image Exclamation;
    private float secondsCount;
    private float currentTime;
    private int tmpTime;
    private float posX;
    private float posY;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        UpdateTimerUI();
        int time = (int)secondsCount;
        InvokeRepeating("createGoldleaf", 0f, 3f);
        if (time % 7==0)
        {
            tmpTime = time+2;
            posX = Random.Range(-2.5f, 2.5f);
            posY = Random.Range(0, 100f);
            if (posY >= 50f)
            {
                posY = 25f;
                Exclamation.transform.position = new Vector3(posX, posY+1, 68.4f);
            }
            else
            {
                posY = 36f;
                Exclamation.transform.position = new Vector3(posX, posY-1, 68.4f);
            }
            gameObject.transform.position = new Vector3(posX, posY, 68.4f);
        
        }
        if(time==tmpTime)
        {
            //Destroy(Exclamation);

        }
    }

    //call this on update
    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
    }


}
