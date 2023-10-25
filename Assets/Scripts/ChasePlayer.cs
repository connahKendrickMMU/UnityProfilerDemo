using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class ChasePlayer : MonoBehaviour
{
    // variable for timing our scripts
    float start;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // record the start time of the 
        start = Time.realtimeSinceStartup;
        Profiler.BeginSample("Update Chase 1");

        // find our player and follow them
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 2 * Time.deltaTime);

        // a simple function to time a method
        Profiler.EndSample();
        Debug.Log("Update Time " + (Time.realtimeSinceStartup - start));
    }
}
