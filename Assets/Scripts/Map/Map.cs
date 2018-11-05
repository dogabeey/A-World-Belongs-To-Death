using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map
{
    Tile[,] tiles = new Tile[100,100];

    public void ConvertNeighbours(int x, int y, double probability, double divide)
    {
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
