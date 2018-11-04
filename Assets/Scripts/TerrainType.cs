using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public class TerrainType
{
    public string name;
    public string imagePath;
    public float speedMultiplier, liveSpaceMultiplier, farmSpaceMultiplier, forageMultiplier, herdingMultiplier, constructionMultiplier, minHeatMultiplier, maxHeatMultiplier;

    public TerrainType(string name, string imagePath, float speedMultiplier, float liveSpaceMultiplier, float farmSpaceMultiplier, float forageMultiplier, float herdingMultiplier, float constructionMultiplier, float minHeatMultiplier, float maxHeatMultiplier)
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
    }
}