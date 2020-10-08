using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float force = 50f;
    public float frequency = 2.0f;
    private float nextLaunch = 0.0f;
    void Start()
    {
        frequency = Random.Range(0.5f, 10.5f);
    }
    void Update()
    {
        if(Time.time > nextLaunch)
        {
            nextLaunch = Time.time + frequency;
            GameObject projectileInstance = Instantiate(projectile, transform.position, transform.rotation);
            projectileInstance.GetComponent<Rigidbody>().AddForce(projectileInstance.transform.forward * force, ForceMode.Impulse);
            GetComponent<AudioSource>().Play();
            Destroy(projectileInstance, 2);
        }
    }
}
