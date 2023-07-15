using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Checkpoints : MonoBehaviour
{
    [HideInInspector]
    public int lap = 0;
    [HideInInspector]
    public int checkPoint = -1;
    int checkPointCount;
    int nextCheckpoint;
    Dictionary<int, bool> visited = new Dictionary<int, bool>();
    public Text lapText;
    void Start()
    {
        GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("checkpoint");
        checkPointCount = checkpoints.Length;

        foreach (GameObject cp in checkpoints)
        {
            visited.Add(Int32.Parse(cp.name), false); // int.Parse(cp.name),
        }

    }

    
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "checkpoint") //col.gameObject.tag == "checkpoint"
        {
            int checkpointCurrent = int.Parse(col.gameObject.name);

            if(checkpointCurrent == nextCheckpoint)
            {
                visited[checkpointCurrent] = true;
                
                checkPoint = checkpointCurrent;
                if(checkPoint==0)
                {
                    lap++;
                    lapText.text = "Lap :"+ lap;
                }

                nextCheckpoint++;
                
                if(nextCheckpoint >= checkPointCount)
                {
                    var keys = new List<int>(visited.Keys);
                    foreach (int key in keys)
                    {
                        visited[key] = false;

                    }

                    nextCheckpoint = 0;

                }
            }

        }


    }
}
