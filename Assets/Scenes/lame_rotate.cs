﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lame_rotate : MonoBehaviour
{

    [SerializeField] private int vitesse;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * vitesse);
    }
}
