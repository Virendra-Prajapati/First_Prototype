using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTargetFrameRate : MonoBehaviour
{
    public int frameRate = 50;
    void Awake()
    {
        Application.targetFrameRate = frameRate;
    }
}
