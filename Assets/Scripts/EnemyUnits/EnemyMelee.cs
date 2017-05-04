using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMelee : MonoBehaviour {
    private Transform target;
    private Transform goal;
    private Animator anim;
    public GameObject aoe;
    public float range;
    public float turnSpeed;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        InvokeRepeating("SearchNearbyEnemy", 0.5f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        if (target == null)
            return;

            Vector3 dir = target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            Vector3 rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime*turnSpeed).eulerAngles;
            transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);
            anim.SetBool("Attack", true);
            
	}
    void SearchNearbyEnemy()
    {
        GameObject[] playerUnits = GameObject.FindGameObjectsWithTag("PlayerUnit");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach(GameObject playerUnit in playerUnits)
        {
            float distanceToUnit = Vector3.Distance(transform.position, playerUnit.transform.position);
            if (distanceToUnit <= shortestDistance)
            {
                shortestDistance = distanceToUnit;
                nearestEnemy = playerUnit;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
            anim.SetBool("Attack", false);
        }
    }

    public void AttackTarget()
    {
        if(target != null)
        Instantiate(aoe, target.transform.position, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
