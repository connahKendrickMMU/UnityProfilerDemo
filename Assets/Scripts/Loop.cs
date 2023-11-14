using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class Loop : MonoBehaviour
{
    // how many times we should loop
    public int loopTimes;
    float start;

    private void OnTriggerEnter(Collider other)
    {
        // record the start time of the 
        start = Time.realtimeSinceStartup;
        Profiler.BeginSample("Time loop");

        for(int i = 0; i < loopTimes; i++)
        {
            Debug.Log(i);
        }

        // a simple function to time a method
        Profiler.EndSample();
        Debug.Log("Update Time for " + loopTimes + " loops = " + (Time.realtimeSinceStartup - start));
        // pause unity
        Debug.Break();
    }
}
