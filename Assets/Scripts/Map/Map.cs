using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    public int height = 100, width = 100;
    public Button button;
    Tile[,] tiles;

    void Start()
    {
        Color tileColor = button.GetComponent<Image>().color;
        button.enabled = true;
        tiles = new Tile[width, height];
        Debug.Log("Started start");
        new TerrainType("desert", "desert.png", new Color32(200,180,45,255));
        new TerrainType("forest", "forest.png", new Color32(120, 180, 80, 255));
        new TerrainType("jungle", "jungle.png", new Color32(50, 130, 15, 255));
        new TerrainType("savannah", "savannah.png", new Color32(200, 130, 0, 255));
        new TerrainType("concrete", "concrete.png", new Color32(190, 190, 180, 255));

        new TerrainFeature("hill", "hill.png");
        new TerrainFeature("plain", "plain.png");
        new TerrainFeature("lake", "plain.png");
        new TerrainFeature("ruin", "plain.png");

        GenerateMap();
        DrawMap(1);
    }

    public void ConvertNeighbours(int x, int y, double probability, double divide, TerrainType terrainType = null)
    {
        if (terrainType != null) tiles[x, y].terrain = terrainType;
        if (x <= 0 || x >= tiles.GetLength(0) - 1 || y <= 0 || y >= tiles.GetLength(1) - 1) return;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                float rand = Random.Range(0, 100);
                if (probability > rand)
                {
                    tiles[x + i * (int)Mathf.Pow(-1, j), y + (1 - i) * (int)Mathf.Pow(-1, j)].terrain = tiles[x, y].terrain;
                    ConvertNeighbours(x + i * (int)Mathf.Pow(-1, j), y + (1 - i) * (int)Mathf.Pow(-1, j), probability / divide, divide);
                }
                else return;
            }
        }
    }

    public void GenerateMap()
    {
        Debug.Log("Started generating");
        for (int i = 0; i < tiles.GetLength(0); i++)
        {
            for (int j = 0; j < tiles.GetLength(1); j++)
            {
                tiles[i, j] = Tile.RandomTile();
                //Debug.Log("Map's (" + (i + 1) + ", " + (j + 1) + ") coordinates has a(n) " + tiles[i, j].terrain.name);
            }
        }
        ConvertNeighbours(3, 3, 100, 1.1, TerrainType.instances.Find(t => t.name == "desert"));
    }

    public void  DrawMap(float spaceBetweenButtons)
    {
        for (int i = 0; i < tiles.GetLength(0); i++)
        {
            for (int j = 0; j < tiles.GetLength(1); j++)
            {
                Button drawnTile = Instantiate(button, button.transform.parent);
                drawnTile.transform.localPosition = new Vector3(i * button.GetComponent<RectTransform>().sizeDelta.x, j * button.GetComponent<RectTransform>().sizeDelta.y);
                drawnTile.GetComponent<Image>().color = tiles[i, j].terrain.color;
                drawnTile.GetComponentInChildren<Text>().text = tiles[i, j].terrain.name;
                drawnTile.GetComponent<TileControl>().tile = tiles[i, j];
                drawnTile.GetComponent<TileControl>().x = i;
                drawnTile.GetComponent<TileControl>().y = j;
                drawnTile.enabled = true;
                button.enabled = false;
            }
        }
    }
}
