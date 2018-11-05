using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public class Tile
{
    public static List<Tile> instances = new List<Tile>();

    public TerrainType terrain;
    public TerrainFeature feature;
    public int base_buildingCapacity;
    public int base_popCapacity;

    public int population;
    public int zombieCount;
    public Faction faction;
    public List<Building> buildings;

    public Tile()
    {
        instances.Add(this);
    }
    public Tile(TerrainType terrain, TerrainFeature feature, int base_buildingCapacity, int base_popCapacity)
    {
        this.terrain = terrain;
        this.feature = feature;
        this.base_buildingCapacity = base_buildingCapacity;
        this.base_popCapacity = base_popCapacity;
        instances.Add(this);
    }
    public Tile(string terrain, string feature, int base_buildingCapacity, int base_popCapacity)
    {
        if (TerrainType.instances.Exists(t => t.name == terrain))
            this.terrain = TerrainType.instances.Find(t => t.name == terrain);
        else Debug.Log("ERROR: No terrain named " + terrain + " exists.");
        if (TerrainFeature.instances.Exists(t => t.name == feature))
            this.feature = TerrainFeature.instances.Find(t => t.name == feature);
        else Debug.Log("ERROR: No feature named " + terrain + " exists.");
        this.base_buildingCapacity = base_buildingCapacity;
        this.base_popCapacity = base_popCapacity;
        instances.Add(this);
    }

    public int PopCapacity
    {
        get
        {
            return Mathf.RoundToInt(base_popCapacity * terrain.liveSpaceMultiplier * feature.liveSpaceMultiplier);
        }

        set
        {
            base_popCapacity = value;
        }
    }

    public int BuildingCapacity
    {
        get
        {
            return Mathf.RoundToInt(base_buildingCapacity * terrain.liveSpaceMultiplier * feature.liveSpaceMultiplier);
        }

        set
        {
            base_buildingCapacity = value;
        }
    }
}