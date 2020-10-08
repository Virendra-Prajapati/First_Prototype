using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    private AudioSource myAudio ;
    public AudioClip musicClip;
    private bool introMusicIsPlaying = true;
    private bool looping = false;
    public AudioClip victoryMusic;
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        PlayBackgroundMusic();        
    }
    void Update()
    {
        if (!myAudio.isPlaying)
        {
            introMusicIsPlaying = false;
        }
        if(!introMusicIsPlaying && !looping)
        {
            looping = true;
            LoopBackgroundMusic();
        }
    }
    void PlayBackgroundMusic()
    {
        if(myAudio.isPlaying == true)
        {
            myAudio.Stop();
        }
        myAudio.Play();
    }
    void LoopBackgroundMusic()
    {
        if(myAudio.isPlaying == true)
        {
            myAudio.Stop();
        }
        myAudio.clip = musicClip;
        myAudio.loop = enabled;
        myAudio.Play();
    }
    public void PlayVictoryMusic()
    {
        if(myAudio.isPlaying == true)
        {
            myAudio.Stop();
        }
        myAudio.clip = victoryMusic;
        myAudio.Play();
    }
}
