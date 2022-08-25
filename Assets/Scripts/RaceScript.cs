using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaceScript : MonoBehaviour
{
    public float laptime;
    private bool startTimer = false;

    private bool checkPoint1 = false;
    private bool checkPoint2 = false;
    
    public UnityEngine.UI.Text Ltime;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
            startTimer = true;
            checkPoint1 = false;
            checkPoint2 = false;
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
