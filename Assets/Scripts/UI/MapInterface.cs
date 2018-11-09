using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapInterface : MonoBehaviour
{
    public Text tileType, ownerName, coordinates, pop;
    Button selected;
    public Button Selected
    {
        get
        {
            return selected;
        }
        set
        {
            selected = value;
            OnTileSelect();
        }
    }

    void Start ()
    {
		
	}

	void Update ()
    {
		
	}

    void OnTileSelect()
    {
        Tile tile = selected.GetComponent<TileControl>().tile;
        tileType.text = tile.terrain.name + " " + tile.feature.name;
        ownerName.text = tile.faction != null ? tile.faction.name : "Unoccupied";
        pop.text = "Population: " + tile.population.ToString();
        coordinates.text = "( " + selected.GetComponent<TileControl>().x + " , " + selected.GetComponent<TileControl>().y + " )";
     }
}
