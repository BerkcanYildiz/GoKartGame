using System;
using UnityEngine;


public class RaceScript : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private UnityEngine.UI.Text Ltime;
    [SerializeField] private UnityEngine.UI.Text BTime;
    private float LapTime = 0;
    private float bestTime = 0;
    
    private bool checkPoint1 = false;
    private bool checkPoint2 = false;
    private bool startTimer = false;
    
    private void Update()
    {
        
        if (startTimer)
        {
            LapTime += Time.deltaTime;    
            // Debug.Log(laptime);
            Ltime.text = "Time: " + LapTime.ToString("F3");
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "StartFinish")
        {
            if (startTimer == false)
            {
                startTimer = true;
                checkPoint1 = false;
                checkPoint2 = false;
            }
            if (checkPoint1 && checkPoint2) 
            {
                startTimer = false;
                
                if (bestTime == 0)
                {
                    bestTime = LapTime;
                }
                if (LapTime < bestTime)
                {
                    bestTime = LapTime;
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
    private void OnCollisionEnter(Collision collision)
    {
        GameOverScreen.SetActive(true);
    }
}
