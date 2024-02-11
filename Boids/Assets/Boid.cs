using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour
{
    private Neighbourhood neighbourhood;
    
    private Rigidbody rigid;

    // using this for initialization
     void Awake()
    {
        neighbourhood = GetComponent<Neighbourhood>();
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

        // _____COLLISION AVOIDANCE_______ Avoiding neighbours that are too near
        Vector3 velAvoid = Vector3.zero;
        Vector3 tooNearPos = neighbourhood.avgNearPos;
        // if the response is vector3.zero, then no need to react
        if(tooNearPos!=Vector3.zero)
        {
            velAvoid = pos - tooNearPos;
            velAvoid.Normalize();
            sumVel += velAvoid * bSet.nearAvoid;
        }

        // _____VELOCITY MATCHING______ trying to match velocity w neighbours
        Vector3 velAlign = neighbourhood.avgVel;
        // only do more if the velAlign is not vector3.zero
        if(velAlign!=Vector3.zero)
        {
            velAlign.Normalize();
            sumVel += velAlign * bSet.velMatching;
        }

        // _____FLOCK CENTERING______ moving towards the center of local neighbours
        Vector3 velCenter = neighbourhood.avgPos;
        if(velCenter!=Vector3.zero)
        {
            velCenter -= transform.position;
            velCenter.Normalize();
            sumVel += velCenter * bSet.flockCentering;
        }

        // ______INTERPOLATE VELOCITY_____ between normalizeVel and sumVel
        sumVel.Normalize();
        vel = Vector3.Lerp(vel.normalized, sumVel, bSet.velocityEasing);
        vel *= bSet.velocity;

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
