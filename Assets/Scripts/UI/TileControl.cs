using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class TileControl : MonoBehaviour
{
    public Tile tile;
    public int x, y;
    public GameObject worldModel;

    private void Start()
    {
        worldModel = GameObject.FindGameObjectWithTag("world");
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

    void OnMouseUpAsButton()
    {
        for (int i = 0; i < worldModel.GetComponentsInChildren<Outline>().Length; i++)
        {
            worldModel.GetComponentsInChildren<Outline>()[i].eraseRenderer = true;
        }
        gameObject.GetComponent<Outline>().eraseRenderer = false;
    }
}
