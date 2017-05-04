using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {
    public float currentRotation;
    public GameObject camera;
    public bool isRotating;
    public float positionX,positionZ;
	// Use this for initialization
	void Start () {
        camera = GameObject.Find("Camera");
        isRotating = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(isRotating)
        RotateCamera();
	}
     void RotateCamera()
    {

        
        if(currentRotation == 0)
        {
            if (positionX == 0)
                positionX = camera.transform.position.x - 10;
            if (camera.transform.position.x > positionX)
            {
                camera.transform.position = Vector3.Lerp(camera.transform.position, new Vector3(positionX-0.1f, transform.position.y, camera.transform.position.z), 0.1f);
                camera.transform.eulerAngles = Vector3.Lerp(camera.transform.eulerAngles,new Vector3(0,90,0),0.1f);
            }
            else
            {
                transform.position = new Vector3(Mathf.Round(transform.position.x), transform.position.y, transform.position.z);
                camera.transform.eulerAngles = new Vector3(transform.eulerAngles.x,90, transform.eulerAngles.z);
                positionX = 0;
                currentRotation = 1;
                isRotating = false;
                
            }
        }
        else if(currentRotation == 1)
        {
            if (positionZ == 0)
                positionZ = camera.transform.position.z + 10;
            if (camera.transform.position.z < positionZ)
            {
                camera.transform.position = Vector3.Lerp(camera.transform.position, new Vector3(camera.transform.position.x, camera.transform.position.y,positionZ+0.1f), 0.1f);
                camera.transform.eulerAngles = Vector3.Lerp(camera.transform.eulerAngles, new Vector3(0, 180, 0), 0.1f);
            }
            else
            {
                transform.position = new Vector3(Mathf.Round(transform.position.x), transform.position.y, transform.position.z);
                positionZ = 0;
                currentRotation = 2;
                isRotating = false;
               
            }
        }
        else if (currentRotation == 2)
        {
            if (positionX == 0)
                positionX = camera.transform.position.x + 10;
            if (camera.transform.position.x < positionX)
            {
                camera.transform.position = Vector3.Lerp(camera.transform.position, new Vector3(positionX + 0.1f, transform.position.y, camera.transform.position.z), 0.1f);
                camera.transform.eulerAngles = Vector3.Lerp(camera.transform.eulerAngles, new Vector3(0, 270, 0), 0.1f);
            }
            else
            {
                transform.position = new Vector3(Mathf.Round(transform.position.x), transform.position.y, transform.position.z);
                positionX = 0;
                currentRotation = 3;
                isRotating = false;

            }
        }
        else if (currentRotation == 3)
        {
            if (positionZ == 0)
                positionZ = camera.transform.position.z - 10;
            if (camera.transform.position.z > positionZ)
            {
                camera.transform.position = Vector3.Lerp(camera.transform.position, new Vector3(camera.transform.position.x, camera.transform.position.y, positionZ-0.1f), 0.1f);
                camera.transform.eulerAngles = Vector3.Lerp(camera.transform.eulerAngles, new Vector3(0, 360, 0), 0.1f);
            }
            else
            {
                transform.position = new Vector3(Mathf.Round(transform.position.x), transform.position.y, transform.position.z);
                camera.transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
                positionZ = 0;
                currentRotation = 0;
                isRotating = false;

            }
        }
    }
    public void CameraRotate()
    {
        isRotating = true;
    }
}
