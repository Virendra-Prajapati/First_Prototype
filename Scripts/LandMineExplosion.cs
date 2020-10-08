using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandMineExplosion : MonoBehaviour
{
    public GameObject victim;
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        victim = GameObject.FindWithTag("Player");
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Explosion();
        }
    }
    void Explosion()
    {
        victim.GetComponent<GoRagdoll>().GotoRagdoll();
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
    
}
