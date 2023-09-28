using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoverBot : MonoBehaviour
{
    public List<Vector3> path;
    public float speed = 3;

    [Range(0.1f, 1)]
    public float minDistance = 0.3f;

    Vector3 target;
    int targetIndex = 0;

    private void Start()
    {
        //start from the first point
        target = path[0];
    }

    void Update()
    {
        var direction = target - transform.position;
        var distance = direction.magnitude;

        //move towards target
        transform.position += direction.normalized * speed * Time.deltaTime;

        //check if target is reached - next target
        if (distance <= minDistance)
        {
            targetIndex++;
            target = path[targetIndex];
        }
    }
}
