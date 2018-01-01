using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeafsquare : MonoBehaviour {
    public Vector3 center;
    public Vector3 size;

    public GameObject leaf;
    // Use this for initialization
    void Start () {
        for (int spawnTimes = 0; spawnTimes < 2010; spawnTimes++)
        {
            SpawnLeaves();
        }
            
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Q))
            SpawnLeaves();
	}

    public void SpawnLeaves()
    {
        Quaternion spawnRotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), 0);
        GameObject newLeaf = (GameObject)Instantiate(leaf, pos, spawnRotation);
        newLeaf.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(Random.Range(0.15f, 0.5f), 1, 1);
        newLeaf.transform.parent = transform;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
