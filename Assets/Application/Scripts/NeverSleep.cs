using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeverSleep : MonoBehaviour 
{
    private void Awake () 
    {
        Screen.sleepTimeout = (int) 0f;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}