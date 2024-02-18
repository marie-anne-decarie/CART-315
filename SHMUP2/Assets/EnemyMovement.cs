using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{


    public Vector3 pointB;

    IEnumerator Start()
    {
    
        Vector3 pointA = transform.position;
        pointB = new Vector3(transform.position.x + 2, transform.position.y, 0);
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.0f));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, 3.0f));
        }
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }
}
