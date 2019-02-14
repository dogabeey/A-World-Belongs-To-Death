using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class TileControl : MonoBehaviour
{
    public Tile tile;
    public int x, y;
    GameObject worldModel;
    static GameObject activeTile;

    private void Start()
    {
        worldModel = GameObject.FindGameObjectWithTag("world");
        activeTile = null;
    }

    public List<GameObject> GetNeighbors()
    {
        Collision col = gameObject.GetComponent<Collision>();
        List<GameObject> retVal = new List<GameObject>();
        for (int i = 0; i < col.contactCount; i++)
        {
            if (!retVal.Exists(g => g == col.GetContact(i).otherCollider.gameObject)) retVal.Add(col.GetContact(i).otherCollider.gameObject);
        }
        return retVal;
    }

    void OnMouseDown()
    {
        if (activeTile != null)
        {
            Debug.Log("Deactivated " + gameObject.name);
            activeTile.GetComponent<Outline>().eraseRenderer = true;
        }
        Debug.Log("Mouse clicked on" + gameObject.name);
        gameObject.GetComponent<Outline>().eraseRenderer = false;
        activeTile = gameObject;
    }
}
