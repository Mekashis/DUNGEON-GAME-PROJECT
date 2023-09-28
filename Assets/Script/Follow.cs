using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float speed = 1;
    public float followDistance = 4;

    void Update()
    {
        var direction = target.position - transform.position;
        var distance = direction.magnitude;
        direction.Normalize();

        if (distance <= followDistance)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
        direction.Normalize();

        if (direction != Vector3.zero)
            transform.forward = direction;


    }

}
