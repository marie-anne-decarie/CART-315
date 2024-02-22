using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour   
{
    public GameObject enemy;
    public int enemyRow, enemyColumn;
    public float enemyHSpacing, enemyVSpacing;
    public float offsetH, offsetV;


  void Start()
  {
     for(int i=0; i<enemyRow; i++)
        {
            for(int j=0; j<enemyColumn; j++)
            {
                float xPos = offsetH + (i * enemyHSpacing);
                float yPos = offsetV + (j * enemyVSpacing);
                Instantiate(enemy, new Vector3(xPos, yPos, 0), Quaternion.identity);

            }
            
            
        }
        
  }





}

