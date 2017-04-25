using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRange : MonoBehaviour {
    public GameObject bullet;
    List<GameObject> target;
	// Use this for initialization
	void Start () {
        target = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        if(target.Count != 0)
        {
            List<float> unitDistance = new List<float>();
            foreach(GameObject soldier in target)
            {
              unitDistance.Add(Vector3.Distance(gameObject.transform.position, soldier.transform.position));
            }
        }
	}
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "PlayerUnit")
        target.Add(col.gameObject);
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "PlayerUnit")
            target.Remove(col.gameObject);
    }
}
