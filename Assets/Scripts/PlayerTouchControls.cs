﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchControls : MonoBehaviour {
    RaycastHit hit;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                // Create a particle if hit
                if (Physics.Raycast(ray, out hit))
                {
                    Debug.Log(hit.collider.name);
                    if (hit.collider.name == "Portal")
                        Debug.Log("IT WORKS");
                }
            }
        }
    }
}
