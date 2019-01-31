using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileControl : MonoBehaviour
{
    public Tile tile;
    public int x, y;

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
        gameObject.SetActive(false);
    }
}
