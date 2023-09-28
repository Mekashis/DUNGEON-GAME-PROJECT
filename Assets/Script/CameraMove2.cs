using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove2 : MonoBehaviour
{
    public GameObject player;


    void Start()
    {
        player = GameObject.Find("character-human"); 
    }


    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z - 2);
    }
}
