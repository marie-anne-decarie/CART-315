using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour   
{
    public GameObject enemy;
    public int startPoint;

    public float resetTime = 1f;
    public float timer = 1f;


    private void Update()
    {
        timer -= 1 * Time.deltaTime;
        if(timer<=0)
        {
            Instantiate(enemy, new Vector3(Random.Range(-7,7), startPoint, 0), Quaternion.identity);
            timer = resetTime;

        }
    }







}

