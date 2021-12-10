using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMobil : MonoBehaviour
{
    
    public GameObject[] prefabPool;
    private int randomPrefab;
    public Transform spawnPos;
    private float spawnTime = 4f;
    // Start is called before the first frame update
    
    void Start()

    {
        
        InvokeRepeating("Spawn", spawnTime, spawnTime); 
    }
    void Spawn()

    {
        
        randomPrefab = Random.Range(0, prefabPool.Length);
        Instantiate(prefabPool[randomPrefab], spawnPos.position,spawnPos.rotation);
    }
    
   
}
