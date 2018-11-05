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

        tiles = new Tile[width, height];
        Debug.Log("Started start");
        new TerrainType("desert", "desert.png",Color.yellow);
        new TerrainType("forest", "forest.png",Color.green);
        new TerrainFeature("hill", "hill.png");
        new TerrainFeature("plain", "plain.png");

        GenerateMap();
    }

    public void ConvertNeighbours(int x, int y, double probability, double divide)
    {
        if (x <= 0 || x >= tiles.GetLength(0) || y <= 0 || y >= tiles.GetLength(1)) return;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                float rand = UnityEngine.Random.Range(0, 100);
                if (probability > rand)
                {
                    tiles[x + (int)Mathf.Pow(-1, i), (int)Mathf.Pow(-1, j)].terrain = tiles[x, y].terrain;
                    ConvertNeighbours(x + (int)Mathf.Pow(-1, i), (int)Mathf.Pow(-1, j), probability / divide, divide);
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
    }

    public void  DrawMap(float spaceBetweenButtons)
    {
        for (int i = 0; i < tiles.GetLength(0); i++)
        {
            Debug.Log(button.GetComponent<RectTransform>().sizeDelta.x);
            for (int j = 0; j < tiles.GetLength(1); j++)
            {
                Button drawnTile = Instantiate(button,button.transform.parent);
                drawnTile.transform.localPosition = new Vector3(i * button.GetComponent<RectTransform>().sizeDelta.x, j * button.GetComponent<RectTransform>().sizeDelta.y);
            }
        }
    }
}
