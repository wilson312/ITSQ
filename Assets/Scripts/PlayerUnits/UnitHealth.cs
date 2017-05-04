using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnitHealth : MonoBehaviour {
    public float maxHealth;
    public float currentHealth;
    public GameObject unitHealthBar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    public void UpdateHealth(float damage)
    {
        currentHealth -= damage;
        unitHealthBar.GetComponent<Image>().fillAmount = currentHealth / maxHealth;
        if (currentHealth <= 0)
            Destroy(gameObject);
    }
}
