using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    static  int score;



    public void OnCollisionEnter(Collision collision)
    {        
            Destroy(gameObject);
            score++;
            Debug.Log("Score : " + score);
    }

}
