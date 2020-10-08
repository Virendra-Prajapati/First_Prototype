using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLandMinePosition : MonoBehaviour
{
    public GameObject prefab;
    public int amount = 10;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<amount; i++)
        {
            Vector3 position = new Vector3(Random.Range(-3.5f, 3.5f), Random.Range(8.5f, 9.0f), Random.Range(55f, 89f));
            Instantiate(prefab, position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
