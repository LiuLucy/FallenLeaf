using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {
    private bool buttonClicked;
    private GameObject leaf;

    Vector3 leafvec;
    bool leafshake;
    void Start()
    {
        leafshake = true;
        leaf = GameObject.FindGameObjectWithTag("leaf");
        buttonClicked = false;
        leafvec = GameObject.Find("leaf").transform.position;
    }
    void Update()
    {
        
        if (buttonClicked)
        {
            Debug.Log(leaf.transform.position.y);
            if (leaf.transform.position.y > -6f)
                leaf.transform.position += Vector3.down * 4.0f * Time.deltaTime;
        }


        if (leaf.transform.localRotation.z > 0.4f)
        {
            leafshake = true;
        }
        if (leaf.transform.localRotation.z < -0.4)
        {
            leafshake = false;
        }

        if (leafshake)
        {
            leaf.transform.RotateAround(leafvec, Vector3.forward, 0.5f);
        }
        else
        {
            leaf.transform.RotateAround(leafvec, Vector3.forward, -0.5f);
        }


    }
    public void Clicked()
    {
        buttonClicked = true;
        Invoke("ChangeScene", 1.5f);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }



}
