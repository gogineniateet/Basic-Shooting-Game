using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 5f)
        {
            float x = Random.Range(-15.0f, 15.0f);
            float z = Random.Range(15.0f, -15.0f);
            Instantiate(enemyPrefab, new Vector3(x, 2, z), Quaternion.identity);
            time = 0f;
        }
    }



}
