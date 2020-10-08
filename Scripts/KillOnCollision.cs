using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KillOnCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "ThirdPersonCharacterRagdoll")        
        {        
            other.gameObject.GetComponent<GoRagdoll>().GotoRagdoll();        
        } 
    }
    public void OnParticleCollision(GameObject other)
    {
        if(other.gameObject.name == "ThirdPersonCharacterRagdoll")
        {
            other.gameObject.GetComponent<GoRagdoll>().GotoRagdoll();
        }
    }
}

