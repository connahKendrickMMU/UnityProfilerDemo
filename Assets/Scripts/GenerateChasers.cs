using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class GenerateChasers : MonoBehaviour
{
    public GameObject spawnable;
    public int spawnCount;

    // Start is called before the first frame update
    void Start()
    {
        Profiler.BeginSample("Start spawning");
        // loop around and spawn objects
        for (int i = 0; i < spawnCount; i++)
        {
            // spawn an object in random positions
            Instantiate(spawnable, new Vector3(Random.Range(-50, 50), Random.Range(1, 50), Random.RandomRange(-50, 50)), new Quaternion());
        }
        Profiler.EndSample();
    }

}
