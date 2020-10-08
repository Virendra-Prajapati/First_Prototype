using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserLayout : MonoBehaviour
{
    public GameObject prefab;
    public float zPos = 91.0f;
    public int numberLength = 16;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberLength*2; i++)
        {
            Vector3 position = new Vector3(-3.8f, 12, zPos);
            Instantiate(prefab, position, Quaternion.identity);
            zPos = zPos + 0.5f;
        }

    }
}
