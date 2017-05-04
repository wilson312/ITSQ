using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerTouchControls : MonoBehaviour {
    RaycastHit hit;
    bool showSelection;
    public RectTransform selection;
    public GameObject selectedPortal;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if(showSelection)
        selection.anchoredPosition = Vector2.Lerp(selection.anchoredPosition, new Vector2(0, 75), .3f);
        else
            selection.anchoredPosition = Vector2.Lerp(selection.anchoredPosition, new Vector2(0, -110), .3f);
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
                    {
                        selectedPortal = hit.collider.gameObject;
                        showSelection = true;
                    }
                   
                }
            }
        }
    }
    public void CloseSelection()
    {
        showSelection = false;
    }
}
