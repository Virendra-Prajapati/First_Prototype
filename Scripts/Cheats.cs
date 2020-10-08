using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    public GameObject player;
    private Vector3 relocationPoint;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        CheckInput();
    }
    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            relocationPoint = new Vector3(0, 9 ,18);
            RelocatePlayer();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            relocationPoint = new Vector3(0, 9, 33.5f);
            RelocatePlayer();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            relocationPoint = new Vector3(0, 9, 43);
            RelocatePlayer();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            relocationPoint = new Vector3(0, 9, 54);
            RelocatePlayer();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            relocationPoint = new Vector3(0, 9, 90);
            RelocatePlayer();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            relocationPoint = new Vector3(0, 9, 108);
            RelocatePlayer();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            relocationPoint = new Vector3(0, 9, 127);
            RelocatePlayer();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            player.GetComponent<GoRagdoll>().Invincibility();
        }
    }
    void RelocatePlayer()
    {
        if(player != null)
        {
            player.transform.position = relocationPoint;
            player.GetComponent<GoRagdoll>().ExitRagdoll();
        }
    }
}
