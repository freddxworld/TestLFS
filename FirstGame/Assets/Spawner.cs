using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject stopper;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawner(); 
            timer = 0;
        }
          
    }
    void spawner()
    {
        float lowestpoint = transform.position.y - heightOffset;
        float highestpoint = transform.position.y + heightOffset;
        Instantiate(stopper, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
}
