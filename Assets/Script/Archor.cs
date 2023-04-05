using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archor : MonoBehaviour
{
    [SerializeField] GameObject bulletObject;
    [SerializeField] Transform shootPos;
    [SerializeField] Transform endPos;

    [SerializeField] float journeyTime;
    [SerializeField] float startTime;
    [SerializeField] float reduceHeight;


    [SerializeField] KeyCode _shootKey;
    [SerializeField] int power;

    private int test;

    private void Awake()
    {
        startTime = Time.time;
    }

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 500);
        }
    }

    void Shoot()
    {
        
    }
}
