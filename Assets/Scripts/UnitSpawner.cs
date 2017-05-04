using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UnitSpawner : MonoBehaviour {
    TextMeshProUGUI text;
    public GameObject knight,chosenPortal;
    public PlayerTouchControls playerTouchController;
    public int startingGold;
	// Use this for initialization
	void Start () {
        text = GetComponent<TextMeshProUGUI>();
        text.SetText("Gold: {0}",startingGold);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void BuyKnight()
    {
        chosenPortal = playerTouchController.selectedPortal;
        if (startingGold >= 100)
        {
            startingGold -= 100;
            text.SetText("Gold: {0}", startingGold);
            Instantiate(knight, chosenPortal.transform.position, transform.rotation);
        }
    }
}
