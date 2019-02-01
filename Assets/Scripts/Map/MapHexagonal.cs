using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapHexagonal : MonoBehaviour
{
    public GameObject worldModel;
    Tile[] tiles;

    void Start()
    {
        tiles = new Tile[worldModel.transform.childCount];
        new TerrainType("desert", "desert.png", new Color32(200, 180, 45, 255));
        new TerrainType("forest", "forest.png", new Color32(120, 180, 80, 255));
        new TerrainType("jungle", "jungle.png", new Color32(50, 130, 15, 255));
        new TerrainType("savannah", "savannah.png", new Color32(200, 130, 0, 255));
        new TerrainType("concrete", "concrete.png", new Color32(190, 190, 180, 255));

        new TerrainFeature("hill", "hill.png");
        new TerrainFeature("plain", "plain.png");
        new TerrainFeature("lake", "plain.png");
        new TerrainFeature("ruin", "plain.png");

        GenerateMap();
        DrawMap();
    }

    //public void ConvertNeighbours(int x, int y, double probability, double divide, TerrainType terrainType = null)
    //{
    //    if (terrainType != null) tiles[x, y].terrain = terrainType;
    //    if (x <= 0 || x >= tiles.GetLength(0) - 1 || y <= 0 || y >= tiles.GetLength(1) - 1) return;
    //    for (int i = 0; i < 2; i++)
    //    {
    //        for (int j = 0; j < 2; j++)
    //        {
    //            float rand = Random.Range(0, 100);
    //            if (probability > rand)
    //            {
    //                tiles[x + i * (int)Mathf.Pow(-1, j), y + (1 - i) * (int)Mathf.Pow(-1, j)].terrain = tiles[x, y].terrain;
    //                ConvertNeighbours(x + i * (int)Mathf.Pow(-1, j), y + (1 - i) * (int)Mathf.Pow(-1, j), probability / divide, divide);
    //            }
    //            else return;
    //        }
    //    }
    //}

    public void GenerateMap()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i] = Tile.RandomTile();
        }
    }

    public void DrawMap()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            GameObject hex = worldModel.transform.GetChild(i).gameObject;
            hex.GetComponent<MeshRenderer>().material.color = tiles[i].terrain.color;
            hex.AddComponent<TileControl>().tile = tiles[i];
            //hex.GetComponentInChildren<Text>().text = tiles[i].terrain.name;
        }
    }
}
