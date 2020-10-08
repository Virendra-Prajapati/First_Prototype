using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class MoveLaser : MonoBehaviour
{
    public float speed = 1;
    public double offset;
    // Start is called before the first frame update
    void Start()
    { 
        offset = transform.position.x - 0.2;
        speed = Random.Range(1.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3((float)(Mathf.PingPong(Time.time * speed, 8) + offset), transform.position.y, transform.position.z);
    }
}
