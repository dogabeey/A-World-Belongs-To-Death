using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainFeature
{
    public static List<TerrainFeature> instances = new List<TerrainFeature>();

    public string name;
    public string imagePath;
    public float speedMultiplier, attackerMultiplier, defenderMultiplier, liveSpaceMultiplier, farmSpaceMultiplier, forageMultiplier, herdingMultiplier, constructionMultiplier;

    public TerrainFeature(string name, string imagePath, float speedMultiplier = 1, float attackerMultiplier = 1, float defenderMultiplier = 1, float liveSpaceMultiplier = 1, float farmSpaceMultiplier = 1, float forageMultiplier = 1, float herdingMultiplier = 1, float constructionMultiplier = 1)
    {
        this.name = name;
        this.imagePath = imagePath;
        this.speedMultiplier = speedMultiplier;
        this.attackerMultiplier = attackerMultiplier;
        this.defenderMultiplier = defenderMultiplier;
        this.liveSpaceMultiplier = liveSpaceMultiplier;
        this.farmSpaceMultiplier = farmSpaceMultiplier;
        this.forageMultiplier = forageMultiplier;
        this.herdingMultiplier = herdingMultiplier;
        this.constructionMultiplier = constructionMultiplier;

        instances.Add(this);
    }
}
