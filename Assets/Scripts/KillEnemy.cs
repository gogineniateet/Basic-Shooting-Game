using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    ScoreManager score;
    public float time;
    public void OnCollisionEnter(Collision collision)
    {        
        Destroy(gameObject);
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        score.ScoreCalculator(10);
    }


   

}
