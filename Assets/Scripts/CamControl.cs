using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamControl : MonoBehaviour {

    public Camera camera;
    public float scrollSpeed = 0.1f;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            camera.transform.position = new Vector3(camera.transform.position.x + scrollSpeed, camera.transform.position.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            camera.transform.position = new Vector3(camera.transform.position.x - scrollSpeed, camera.transform.position.y);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y - scrollSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y + scrollSpeed);
        }
    }
}
