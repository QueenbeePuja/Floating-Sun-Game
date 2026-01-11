using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpawner : MonoBehaviour
{

    public GameObject cloud;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightoffset = 10;


    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
        
    }
    void spawnCloud()
    {
        float lowerstpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;

        Instantiate(cloud,new Vector3(transform.position.x,Random.Range(lowerstpoint,highestpoint),0), transform.rotation);
    }

}
