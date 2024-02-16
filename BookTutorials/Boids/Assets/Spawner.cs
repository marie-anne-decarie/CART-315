using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BoidSettings
{
    // These fields are for adjusting the flocking behavior of the boids
    public int velocity = 32;
    public int neighbourDist = 10;
    public int nearDist = 4;
    public int attractPushDist = 5;

    [Header("These \"influences \" are floats, usually from [0...4]")]
    public float velMatching = 1.5f;
    public float flockCentering = 1f;
    public float nearAvoid = 2f;
    public float attractPull = 1f;
    public float attractPush = 20f;

    [Header("This determines how quickly boids can turn and is [0...1]")]
    public float velocityEasing = 0.03f;

}

public class Spawner : MonoBehaviour
{
    // Settings and boids are both static to allow easy access
    static public BoidSettings SETTINGS;
    static public List<Boid> BOIDS;

    // These fields allow to adjust the spawning behavior of the boids
    [Header("Inscribed: settings for spawning boids")]
    public GameObject boidPrefab;
    public Transform boidAnchor;
    public int numBoids = 100;
    public float spawnRadius = 100f;
    public float spawnDelay = 0.1f;

    [Header("Inscribed: settings for spawning boids")]
    public BoidSettings boidSettings;

     void Awake()
    {
        //Assign the boidsettings of this  instance to the static SETTINGS
        Spawner.SETTINGS = boidSettings;
        // Starts instanciation of the boids
        BOIDS = new List<Boid>();
        InstantiateBoid();
    }

    public void InstantiateBoid()
    {
        GameObject go = Instantiate<GameObject>(boidPrefab);
        go.transform.position = Random.insideUnitSphere * spawnRadius;
        Boid b = go.GetComponent<Boid>();
        b.transform.SetParent(boidAnchor);
        BOIDS.Add(b);
        if(BOIDS.Count < numBoids)
        {
            Invoke("InstantiateBoid", spawnDelay);
        }
    }
}