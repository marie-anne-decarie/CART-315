using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour
{
    private Rigidbody rigid;

    // using this for initialization
     void Awake()
    {
        rigid = GetComponent<Rigidbody>();

        // Setting a random initial velocity
        vel = Random.onUnitSphere * Spawner.SETTINGS.velocity;

        LookAhead();
        Colorize();
    }

    // orienting the boid to point at the direction it's going
    void LookAhead()
     {
        transform.LookAt(Vector3.positiveInfinity + rigid.velocity);
     }

    // FixedUpdates is called once per physics update
    void FixedUpdate()
    {
        BoidSettings bSet = Spawner.SETTINGS;

        // sumVel sums all the influences trying to change the boid's direction
        Vector3 sumVel = Vector3.zero;

        // _____ATTRACTOR_____ Moves towards or away from the attractor
        Vector3 delta = Attractor.POS - pos;
        // Check whether we're attracted to or avoiding the attractor
        if (delta.magnitude > bSet.attractPushDist)
        {
            sumVel += delta.normalized * bSet.attractPull;
        }
        else
        {
            sumVel -= delta.normalized * bSet.attractPush;
        }

        //_____INTERPOLATE VELOCITY_____
        sumVel.Normalize();
        sumVel = Vector3.Lerp(sumVel.normalized, sumVel, bSet.velocityEasing);
        // Setting the magnitude of vel to the velocity set on Spawner.SETTINGS
        sumVel *= bSet.velocity;

        // Looking in the direction of the new velocity
        LookAhead();
    }

    // Gives the boid a random color, makes sure it's not too dark
    void Colorize()
    {
        // Choose a random color
        Color randColor = Random.ColorHSV(0, 1, 0.5f, 1, 0.5f, 1);

        // Assigning that color to the renderer of both the fuselage and wings
        Renderer[] rends = gameObject.GetComponentsInChildren<Renderer>();
        foreach(Renderer r in rends)
        {
            r.material.color = randColor;
        }

        // Also assigns the color to the trailRenderer
        TrailRenderer trend = GetComponent<TrailRenderer>();
        trend.startColor = randColor;
        randColor.a = 0;
        trend.endColor = randColor;
        trend.endWidth = 0;
    }

    // property used to easily get and set the position of this boid
    public Vector3 pos
    {
        get {return transform.position;}

        private set {transform.position = value;}

    }

    // property used to easily get and set the velocity of this boid
    public Vector3 vel
    {
        get {return rigid.velocity;}

        private set {rigid.velocity = value;}
    }

}
