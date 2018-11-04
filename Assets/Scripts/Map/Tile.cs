using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public class Tile
{
    public TerrainType terrain;
    public TerrainFeature feature;
    public int buildingCapacity;
    public int popCapacity;

    public int population;
    public int zombieCount;
    public Faction faction;
    List<Building> buildings;

    public int PopCapacity
    {
        get
        {
            return Mathf.RoundToInt(popCapacity * terrain.liveSpaceMultiplier * feature.liveSpaceMultiplier);
        }

        set
        {
            popCapacity = value;
        }
    }

    public int BuildingCapacity
    {
        get
        {
            return Mathf.RoundToInt(buildingCapacity * terrain.liveSpaceMultiplier * feature.liveSpaceMultiplier);
        }

        set
        {
            buildingCapacity = value;
        }
    }
}