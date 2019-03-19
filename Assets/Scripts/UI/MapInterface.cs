using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;

public class MapInterface : MonoBehaviour
{
    public Text tileType, ownerName, coordinates, pop;
    Button selected;

    void Start ()
    {
		
	}

	void FixedUpdate ()
    {
        Tile tile = FindObjectsOfType<TileControl>().ToList().Find(t => t.gameObject.GetComponent<cakeslice.Outline>().eraseRenderer == false).tile;
        tileType.text = tile.terrain.name + " " + tile.feature.name;
        ownerName.text = tile.faction != null ? tile.faction.name : "Unoccupied";
        pop.text = "Population: " + tile.Population.ToString();
        //coordinates.text = "( " + selected.GetComponent<TileControl>().x + " , " + selected.GetComponent<TileControl>().y + " )";
    }
}
