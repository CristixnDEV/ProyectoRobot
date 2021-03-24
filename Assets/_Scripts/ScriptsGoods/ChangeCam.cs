using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public Vector3 pointCam;
    public Vector3 rotCam;
    private CheckCollisions _checkCollisions;
    private float speedLinear = 0.5f;

    private void Start()
    {
        _checkCollisions = GameObject.Find("Player").GetComponent<CheckCollisions>();
    }

    private void Update()
    {
        if (_checkCollisions.IsCamChange == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointCam, speedLinear);
            transform.rotation = Quaternion.Euler(rotCam);
        }
    }
}
