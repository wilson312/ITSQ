using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Attack : MonoBehaviour {
    public Image healthBar;
    Animator anim;
    RaycastHit ray;
	// Use this for initialization
	void Start () {
        healthBar = GameObject.Find("HealthBar").GetComponent<Image>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Physics.Raycast(new Vector3(transform.position.x, transform.position.y * 2, transform.position.z), transform.forward, out ray,1))
        {
            if(ray.collider.name == "Goal")
            {
              anim.SetBool("Attack", true);
            }
            
        }

    }
    public void KnightDealDamage()
    {
        healthBar.fillAmount -= 0.01f;
        Debug.Log("I DEAL DAMAGE");
    }
}
