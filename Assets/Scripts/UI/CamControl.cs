using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamControl : MonoBehaviour {

    public new Camera camera;
    [Tooltip("Object that will turn around the camera.")]public GameObject worldModel;
    public float scrollSpeed = 0.1f;
    public float minZoom = 15, maxZoom = 5, zoomSpeed = 1;
    public enum ScrollStyle { world_2d, world_3d }
    public ScrollStyle scrollStyle;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (scrollStyle == ScrollStyle.world_2d)
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
            if (Input.mouseScrollDelta.y > 0 && camera.orthographicSize > maxZoom + zoomSpeed)
            {
                camera.orthographicSize = camera.orthographicSize - zoomSpeed;
                Vector3 pointerPosition = camera.ScreenToWorldPoint(Input.mousePosition);
                camera.transform.position = camera.transform.position - (camera.transform.position - pointerPosition) * scrollSpeed / 4;
            }
            if (Input.mouseScrollDelta.y < 0 && camera.orthographicSize < minZoom - zoomSpeed)
            {
                camera.orthographicSize = camera.orthographicSize + zoomSpeed;
                Vector3 pointerPosition = camera.ScreenToWorldPoint(Input.mousePosition);
                camera.transform.position = camera.transform.position + (camera.transform.position - pointerPosition) * scrollSpeed / 4;
            }
            if (Input.GetKey(KeyCode.Mouse2))
            {
                Vector3 pointerPosition = camera.ScreenToWorldPoint(Input.mousePosition);
                camera.transform.position = camera.transform.position - (camera.transform.position - pointerPosition) * scrollSpeed / 8;
            }
        }
        if (scrollStyle == ScrollStyle.world_3d)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                worldModel.transform.Rotate(new Vector3(0, -scrollSpeed));
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                worldModel.transform.Rotate(new Vector3(0, scrollSpeed));
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                worldModel.transform.Rotate(new Vector3(-scrollSpeed, 0));
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                worldModel.transform.Rotate(new Vector3(scrollSpeed, 0));
            }
            if (Input.mouseScrollDelta.y > 0 && camera.orthographicSize > maxZoom + zoomSpeed)
            {
                camera.orthographicSize = camera.orthographicSize - zoomSpeed;
            }
            if (Input.mouseScrollDelta.y < 0 && camera.orthographicSize < minZoom - zoomSpeed)
            {
                camera.orthographicSize = camera.orthographicSize + zoomSpeed;
            }
        }
    }
}
