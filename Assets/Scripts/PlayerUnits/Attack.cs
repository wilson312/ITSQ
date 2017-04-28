using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    Animator anim;
    RaycastHit ray;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

        Debug.Log(anim.GetBool("Attack"));
	}
	
	// Update is called once per frame
	void Update () {
        if(Physics.Raycast(new Vector3(transform.position.x, transform.position.y * 2, transform.position.z), transform.forward, out ray,2))
        {
            Debug.Log(ray.collider.name);
            if(ray.collider.name == "Goal")
            anim.SetBool("Attack", true);
        }
        Debug.DrawRay(new Vector3(transform.position.x,transform.position.y*2,transform.position.z), transform.forward*1,Color.red);
    }
}
