using UnityEngine.UI;
using UnityEngine;

public class SpeedoMeter : MonoBehaviour
{
    public Rigidbody target;

    [SerializeField] private float maxSpeed; // the max speed of the target 
    [SerializeField] private float minSpeedArrowAngle;
    [SerializeField] private float maxSpeedArrowAngle;

    [Header("UI")] 
    private Text speedLabel; // the label that displays the speed
    public RectTransform arrow; // the arrow in the speedometer

    private float speed;
    private void Update()
    {
        // 3.6f to convert in kilometers
        //the speed must be clamped by the car controllers
        speed = target.velocity.magnitude * 3.6f;

        if (speedLabel != null)
            speedLabel.text = $"{speed.ToString()} km/h";
        
        arrow.localEulerAngles = new Vector3(0, 0,Mathf.Lerp(minSpeedArrowAngle, maxSpeedArrowAngle, speed / maxSpeed) );
    }
}
