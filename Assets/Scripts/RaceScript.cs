using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaceScript : MonoBehaviour
{
    
    
    public float laptime = 0;
    public float bestTime = 0;
    private bool startTimer = false;

    private bool checkPoint1 = false;
    private bool checkPoint2 = false;
    
    public UnityEngine.UI.Text Ltime;
    public UnityEngine.UI.Text BTime;
    
    // Update is called once per frame
    void Update()
    {
        if (startTimer == true)
        {
            laptime = laptime +  Time.deltaTime;    
            // Debug.Log(laptime);
            Ltime.text = "Time: " + laptime.ToString("F3");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "StartFinish")
        {
            if (startTimer == false)
            {
                startTimer = true;
                checkPoint1 = false;
                checkPoint2 = false;
            }
            if (checkPoint1 == true && checkPoint2 == true) 
            {
                startTimer = false;
                
                if (bestTime == 0)
                {
                    bestTime = laptime;
                    Debug.Log(bestTime);
                }
                if (laptime < bestTime)
                {
                    bestTime = laptime; 
                    Debug.Log(bestTime);
                }

                BTime.text = "Best: " + bestTime.ToString("F3");
            }
        }

        if (other.gameObject.name == "checkPoint1")
        {
            checkPoint1 = true;
        }
        if (other.gameObject.name == "checkPoint2")
        {
            checkPoint2 = true;
        }
    }
}
