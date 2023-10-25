using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class ChasePlayer2 : MonoBehaviour
{
    // variable for timing our scripts
    float start;
    Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        // get the player straight away
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // record the start time of the 
        start = Time.realtimeSinceStartup;
        Profiler.BeginSample("Update Chase 2");

        // find our player and follow them
        transform.position = Vector3.MoveTowards(transform.position, Player.position, 2 * Time.deltaTime);

        // a simple function to time a method
        Profiler.EndSample();
        Debug.Log("Update Time " + (Time.realtimeSinceStartup - start));
    }
}
