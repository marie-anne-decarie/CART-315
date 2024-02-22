using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove2 : MonoBehaviour
{


    public Vector3 pointB, pointC, pointD;

    IEnumerator Start()
    {
    
        Vector3 pointA = transform.position;
        pointB = new Vector3(transform.position.x + 2, transform.position.y, 0);
        pointC = new Vector3(transform.position.x, transform.position.y - 2, 0);
        pointD = new Vector3(transform.position.x - 2, transform.position.y, 0);
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, 0.25f));
            yield return StartCoroutine(MoveObject(transform, pointB, pointC, 0.25f));
            yield return StartCoroutine(MoveObject(transform, pointC, pointD, 0.25f));
            yield return StartCoroutine(MoveObject(transform, pointD, pointA, 0.25f));
        }
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        float i = 0.0f;
        float rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }
}
