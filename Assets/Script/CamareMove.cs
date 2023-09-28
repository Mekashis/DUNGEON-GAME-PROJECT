using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamareMove : MonoBehaviour
{
    public GameObject player;


    void Start()
    {
        player = GameObject.Find("character-human (1)"); 
    }


    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 2, player.transform.position.z - 3);
    }
}
