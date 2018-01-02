using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeaf : MonoBehaviour {
    public Vector3 center;
    public Vector3 size;
    
    public GameObject leaf;
    // Use this for initialization
    void Start ()
    {
        for (int spawnTimes = 0; spawnTimes < 110; spawnTimes++)
        {
            float ang = spawnTimes * 30;
            SpawnLeaves(ang,spawnTimes);
        }
            
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Q))
            SpawnLeaves(1,1);
	}

    public void SpawnLeaves(float ang,int i)
    {
        float radius = Random.Range(0,size.y);
         Vector3 circ;
        circ.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        circ.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);

        Quaternion spawnRotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        Vector3 pos =  new Vector3(circ.x, circ.y, 0);
        GameObject newLeaf = (GameObject)Instantiate(leaf, pos, spawnRotation);
        newLeaf.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(Random.Range(0.15f, 0.5f), 1, 1);
        newLeaf.transform.parent = transform;
    }
    private void OnDrawGizmosSelected()
    {
        int radius = (int)size.y;
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawSphere(center, radius);
    }
}
