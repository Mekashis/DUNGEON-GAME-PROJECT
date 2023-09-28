﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float speed = 5;

    void Update()
    {
        

        var direction = new Vector3();
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction.Normalize();

        transform.position += direction * speed * Time.deltaTime;

        if (direction != Vector3.zero)
            transform.forward = direction;
    }
}
