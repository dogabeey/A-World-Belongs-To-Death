using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map
{
    Tile[,] tiles = new Tile[100,100];
    
    public void ConvertNeighbours(int x, int y, double probability, double divide)
    {
        if (x <= 0 || x >= tiles.GetLength(0) || y <= 0 || y >= tiles.GetLength(1)) return;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                float rand = Random.Range(0, 100);
                if (probability > rand)
                {
                    tiles[x + (int)Mathf.Pow(-1, i), (int)Mathf.Pow(-1, j)].terrain = tiles[x, y].terrain;
                    ConvertNeighbours(x + (int)Mathf.Pow(-1, i), (int)Mathf.Pow(-1, j), probability / divide, divide);
                }
                else return;
            }
        }
    }
}
