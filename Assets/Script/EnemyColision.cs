using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColision : MonoBehaviour
{

    Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //print($"name: {collision.gameObject.name}, tag: {collision.gameObject.tag}");

        if (collision.gameObject.tag == "Player")
        {
            transform.position = startPos;
        }

    }
}
