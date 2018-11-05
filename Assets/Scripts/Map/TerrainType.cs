using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public class TerrainType
{
    public static List<TerrainType> instances = new List<TerrainType>();

    public string name;
    public string imagePath;
    public Color color;
    public float speedMultiplier = 1, liveSpaceMultiplier = 1, farmSpaceMultiplier = 1, forageMultiplier = 1, herdingMultiplier = 1, constructionMultiplier = 1, minHeatMultiplier = 1, maxHeatMultiplier = 1;

    public TerrainType(string name, string imagePath, Color tileColor, float speedMultiplier = 1, float liveSpaceMultiplier = 1, float farmSpaceMultiplier = 1, float forageMultiplier = 1, float herdingMultiplier = 1, float constructionMultiplier = 1, float minHeatMultiplier = 1, float maxHeatMultiplier = 1)
    {
        this.name = name;
        this.imagePath = imagePath;
        this.speedMultiplier = speedMultiplier;
        this.liveSpaceMultiplier = liveSpaceMultiplier;
        this.farmSpaceMultiplier = farmSpaceMultiplier;
        this.forageMultiplier = forageMultiplier;
        this.herdingMultiplier = herdingMultiplier;
        this.constructionMultiplier = constructionMultiplier;
        this.minHeatMultiplier = minHeatMultiplier;
        this.maxHeatMultiplier = maxHeatMultiplier;
        
        instances.Add(this);
    }
}