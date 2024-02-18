using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour   
{
    public GameObject enemy;
    public int enemyNum;
    public float enemySpacing;


  void Start()
  {
     for(int i=0; i<enemyNum; i++)
        {
            float xPos = -7 + (i * enemySpacing);
            Instantiate(enemy, new Vector3(xPos, transform.position.y, 0), Quaternion.identity); 
        }
        
  }





}

