using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using UnityEngine;

public class EnemyDroneAI : MonoBehaviour
{
    public Transform playerTransform;
    public float speed = 3.0f;
    private Vector3 drone;
    private Vector3 target;
    private Vector3 direction;
    private float distance;
    void Update()
    {
        if(playerTransform.position.z > 128 && playerTransform.position.z < 145)
        {
            transform.LookAt(playerTransform);
            drone = transform.position;
            target = playerTransform.position + new Vector3(0f, 0.6f, 0f);
            distance = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(drone, target, distance);
        }
        /*else
        {
            drone = transform.position;
            direction = new Vector3(Random.Range(-3.5f, 3.5f), 10f, Random.Range(128f, 145f));
            distance = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(drone, direction, distance);
        }*/
    }
}
