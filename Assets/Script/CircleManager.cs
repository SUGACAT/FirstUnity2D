using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleManager : MonoBehaviour
{
    public float spawnTime;
    float currentTime;

    public GameObject circle;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.Dead) { return; }

        Timer();
    }

    void Timer()
    {
        currentTime -= Time.deltaTime;
        
        if(currentTime <= 0) 
        {
            Spawn();
            currentTime = spawnTime;
        }
    }

    void Spawn()
    {
        Vector3 spawnPos = new Vector3(0, 0, -5);

        GameObject circle_Ins = Instantiate(circle, spawnPos, circle.transform.rotation);
        Debug.Log("Spawned");
    }
}
