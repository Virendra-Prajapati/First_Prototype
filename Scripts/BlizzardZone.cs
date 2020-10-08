using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using UnityEngine;

public class BlizzardZone : MonoBehaviour
{
    public Transform playerTransform;
    public float rateIncrease = 1f;
    private float rate;
    private ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();  
    }

    // Update is called once per frame
    void Update()
    {
        var main = ps.main;
        if(playerTransform.position.z > 109f && playerTransform.position.z < 126f)
        {
            rate = playerTransform.position.z - 104f;
            main.startSpeed = rate * rateIncrease;
        }
    }
}
 