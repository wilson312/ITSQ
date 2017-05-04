using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthLookAt : MonoBehaviour {
    [SerializeField]
    GameObject camera;
	// Use this for initialization
	void Start () {
        camera = GameObject.Find("Camera");
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(camera.transform);
	}
}
