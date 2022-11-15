using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    
    
    public float startDelay = 2;
    public float repeatDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstacle", startDelay, repeatDelay); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnObstacle()
    {
        Vector3 spawnPos = new Vector3(20, Random.Range(0, 8), 0);

        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
