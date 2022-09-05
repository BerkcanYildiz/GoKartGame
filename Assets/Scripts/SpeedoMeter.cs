using System;
using UnityEngine.UI;
using UnityEngine;

public class SpeedoMeter : MonoBehaviour
{
    public Rigidbody target;

    public float maxSpeed = 0.0f; // the max speed of the target 
    public float minSpeedArrowAngle;
    public float maxSpeedArrowAngle;

    [Header("UI")] 
    public Text speedLabel; // the label that displays the speed
    public RectTransform arrow; // the arrow in the speedometer

    private float speed = 0.0f;
    private void Update()
    {
        // 3.6f to convert in kilometers
        //the speed must be clamped by the car controllers
        speed = target.velocity.magnitude * 3.6f;

        if (speedLabel != null)
            speedLabel.text = speed + " km/h";
        if (arrow !=  null)
            arrow.localEulerAngles =
                new Vector3(0, 0,Mathf.Lerp(minSpeedArrowAngle, maxSpeedArrowAngle, speed / maxSpeed) );

    }
}
