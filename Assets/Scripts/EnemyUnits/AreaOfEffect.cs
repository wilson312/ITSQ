using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaOfEffect : MonoBehaviour {
    public float range = 5;
    public float damage = 25;
	// Use this for initialization
	void Start () {
        SearchNearbyEnemy();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void SearchNearbyEnemy()
    {
        GameObject[] playerUnits = GameObject.FindGameObjectsWithTag("PlayerUnit");
        foreach (GameObject playerUnit in playerUnits)
        {
            float distanceToUnit = Vector3.Distance(transform.position, playerUnit.transform.position);
            if (distanceToUnit <= range)
            {
                playerUnit.GetComponent<UnitHealth>().UpdateHealth(damage);
            }
        }
        Destroy(gameObject);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
