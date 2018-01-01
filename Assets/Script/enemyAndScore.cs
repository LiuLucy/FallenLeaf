using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAndScore : MonoBehaviour {
    private float score = 0.0f;
    private int difficultyLevel = 1;
    private int maxDiffucultyLevel = 10;
    private int scoreToNextLevel = 300;
    
    

    private float posX;
    private float posY;
    private float speed;
    private bool movingUp;
    private bool movingDown;
    private bool toogleState;
    public UnityEngine.UI.Image Exclamation;
    public UnityEngine.UI.Text scoreText;
    
    // Use this for initialization
    void Start () {
        movingUp = false;
        InvokeRepeating("Enemy", 5f, 5f);
        speed = 5.0f;
        toogleState = true;
    }

    // Update is called once per frame
    void Update () {
        if (score >= scoreToNextLevel)
            LevelUp();
        score += difficultyLevel*0.3f ;
        scoreText.text = ((int)score).ToString();

        if (movingUp)
        {
            if (transform.position.y < 37)
                transform.position += Vector3.up * speed * Time.deltaTime;
            else
                movingUp = false;

        }
        if (movingDown)
        {
            if (transform.position.y > 24)
                transform.position += Vector3.down * speed * Time.deltaTime;
            else
                movingDown = false;
        }
    }

    void LevelUp()
    {
        if (difficultyLevel == maxDiffucultyLevel)
            return;
        scoreToNextLevel *= 2;
        difficultyLevel++;
        speed += 0.2f;

    }
    

    void SpawnEnemy()
    {
        InvokeRepeating("ToggleState", 0f, 0.3f);
        posX = Random.Range(-2.5f, 2.5f);
        posY = Random.Range(0, 100f);
        if (posY >= 50f)
        {
            if (transform.eulerAngles.z == 270)
                transform.Rotate(0, 0, 180);
            else
                transform.Rotate(0, 0, 0);
            posY = 25f;
            Exclamation.transform.position = new Vector3(posX, 26f, 68.4f);
            gameObject.transform.position = new Vector3(posX, posY, 68.4f);
            Invoke("MovingUp", 2f);
        }
        else
        {
            if(transform.eulerAngles.z == 90)
                transform.Rotate(0, 0, -180);
            else
                transform.Rotate(0, 0, 0);
            posY = 36f;
            Exclamation.transform.position = new Vector3(posX, 35f, 68.4f);
            gameObject.transform.position = new Vector3(posX, posY, 68.4f);
            Invoke("MovingDown", 2f);
        }

    }
    

    void Enemy()
    {
        int spawn = Random.Range(0, difficultyLevel*10);
        if (spawn < Random.Range(difficultyLevel*3, difficultyLevel * 10))
        {
            if(Exclamation.enabled==false)
            {
                toogleState = true;
                Exclamation.enabled = !Exclamation.enabled;
            }
            SpawnEnemy();
        }
    }
    void ToggleState()
    {
        if (toogleState)
            Exclamation.enabled = !Exclamation.enabled;
    }

    void MovingUp()
    {
        toogleState = false;
        if (Exclamation.enabled == true)
            Exclamation.enabled = !Exclamation.enabled;
        movingUp = true;
    }

    void MovingDown()
    {
        toogleState = false;
        gameObject.transform.Rotate(Vector3.down, 0, Space.World);
        if (Exclamation.enabled == true)
            Exclamation.enabled = !Exclamation.enabled;
        movingDown = true;
    }
}
