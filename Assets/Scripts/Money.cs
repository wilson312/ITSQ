using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Money : MonoBehaviour {
    TextMeshProUGUI text;
    float currentGold;
	// Use this for initialization
	void Start () {
        currentGold = 500;
        text = GetComponent<TextMeshProUGUI>();
        text.SetText("Gold: {0}",currentGold);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
