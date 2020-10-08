using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryMusic : MonoBehaviour
{
    public GameObject backgroungMusic;
    public ParticleSystem fireWork;
    void OnTriggerEnter()
    {
        backgroungMusic.GetComponent<BackGroundMusic>().PlayVictoryMusic();
        fireWork.GetComponent<ParticleSystem>().Play();
    }

    
}
