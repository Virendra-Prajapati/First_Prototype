using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCannonPosition : MonoBehaviour
{
    public GameObject prefab;
    public int amount = 10;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= amount; i++)
        {
            Vector3 position = new Vector3(5f, Random.Range(9.0f, 11.0f), Random.Range(44f, 53f));
            Instantiate(prefab, position, Quaternion.Euler(0, 0, 90));
        }    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
