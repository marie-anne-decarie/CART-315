using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neighbourhood : MonoBehaviour
{
    [Header("Dynamic")]
    public List<Boid> neighbours;
    private SphereCollider coll;


    // Start is called before the first frame update
    void Start()
    {
        neighbours = new List<Boid>();
        coll = GetComponent<SphereCollider>();
        coll.radius = Spawner.SETTINGS.neighbourDist;
    }

    void FixedUpdate()
    {
        float nearRadius = Spawner.SETTINGS.neighbourDist * 0.5f;
        if (!Mathf.Approximately(coll.radius, nearRadius)) coll.radius = nearRadius;
    }

    void OnTriggerEnter(Collider other)
    {
        Boid b = other.GetComponent<Boid>();
        if (b != null)
        {
            if (neighbours.Contains(b))
                neighbours.Add(b);

        }
    }

    void OnTriggerExit(Collider other)
    {
        Boid b = other.GetComponent<Boid>();
        if (b != null) neighbours.Remove(b);
    }

    public Vector3 avgPos
    {
        get
        {
            Vector3 avg = Vector3.zero;
            if (neighbours.Count == 0) return avg;
            for (int i = 0; i < neighbours.Count; i++)
                avg += neighbours[i].pos;
            avg /= neighbours.Count;
            return avg;
        }
    }

    public Vector3 avgVel
    {
        get
        {
            Vector3 avg = Vector3.zero;
            if (neighbours.Count == 0) return avg;
            for (int i = 0; i < neighbours.Count; i++)
                avg += neighbours[i].vel;
            avg /= neighbours.Count;
            return avg;
        }
    }

    public Vector3 avgNearPos
    {
        get
        {
            Vector3 avg = Vector3.zero;
            Vector3 delta;
            int nearCount = 0;
            for(int i=0; i<neighbours.Count; i++)
            {
                delta = neighbours[i].pos - transform.position;
                if(delta.magnitude<= Spawner.SETTINGS.nearDist)
                {
                    avg += neighbours[i].pos;
                    nearCount++;
                }
            }

            if (nearCount == 0) return Vector3.zero;
            avg /= nearCount;
            return avg;
        }
    }

}
