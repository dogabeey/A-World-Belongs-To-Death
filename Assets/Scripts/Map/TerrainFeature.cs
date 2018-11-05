using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainFeature
{
    public static List<TerrainFeature> instances = new List<TerrainFeature>();

    public string name;
    public string imagePath;
    public float speedMultiplier, attackerMultiplier, defenderMultiplier, liveSpaceMultiplier, farmSpaceMultiplier, forageMultiplier, herdingMultiplier, constructionMultiplier;

    public TerrainFeature(string name, string imagePath, float speedMultiplier, float attackerMultiplier, float defenderMultiplier, float liveSpaceMultiplier, float farmSpaceMultiplier, float forageMultiplier, float herdingMultiplier, float constructionMultiplier)
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
