using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;

    public void AttackerSpawned()
    {
        numberOfAttackers = numberOfAttackers + 1;

    }

    public void AttackerKilled()
    {
        numberOfAttackers = numberOfAttackers - 1;
        if (numberOfAttackers <= 0 && levelTimerFinished)
        {
            Debug.Log("End Level Now!");


        }
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();

    }

    private  void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();

        }
    }




    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
