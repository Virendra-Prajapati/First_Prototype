using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public LineRenderer line;
    public GameObject sparks;
    public GameObject victim;
    // Start is called before the first frame update
    void Start()
    {
        victim = GameObject.Find("ThirdPersonCharacterRagdoll");
        line = gameObject.GetComponent<LineRenderer>();     
    }

    // Update is called once per frame
    void Update()
    {
        ShowLaser();
    }
    void ShowLaser()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;
        line.SetPosition(0, ray.origin);
        if(Physics.Raycast(ray, out hit, 50))
        {
            line.SetPosition(1, hit.point);
            if(hit.collider == victim.GetComponent<Collider>())
            {
                victim.GetComponent<GoRagdoll>().GotoRagdoll();
            }
            sparks.transform.position = hit.point;
        }
        else
        {
            line.SetPosition(1, ray.GetPoint(50));
        }
        
    }
}
