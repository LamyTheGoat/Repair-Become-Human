﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArmScr : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(1.05f, 0.1f, 0);
    }
}
