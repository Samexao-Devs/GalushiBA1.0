﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonRespawnBlue : MonoBehaviour
{
    [SerializeField] GameObject balloonPrefab1;
    public static float v = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        Instantiate(balloonPrefab1, transform.position, transform.rotation);

    }
}
