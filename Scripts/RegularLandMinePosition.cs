using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularLandMinePosition : MonoBehaviour
{
    public GameObject prefab;
    public float xPos = -3.5f;
    public float yPos = 8.5f;
    public float zPos = 55f;
    public int numberWidth = 8;
    public int numberLength = 34;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberLength/2; i++)
        {
            for(int j = 0; j < numberWidth; j++)
            {
                Vector3 position = new Vector3(xPos, yPos, zPos);
                Instantiate(prefab, position, Quaternion.identity);
                xPos++;
            }
            xPos = -3.5f;
            yPos = yPos + 0.05f;
            zPos = zPos + 2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
