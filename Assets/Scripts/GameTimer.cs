using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer: seconds")]
    [SerializeField] float levelTime = 10;
    bool triggeredLevelFinished = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(triggeredLevelFinished)
        {
            return;

        }

        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);

        if(timerFinished)
        {
            //Debug.Log("level timer expired");
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggeredLevelFinished = true;


        }

    }
}
