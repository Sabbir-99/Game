
   
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class SpeedOmeter : MonoBehaviour
{
    

    public Rigidbody Car;

    public float maxSpeed = 0.0f; // The maximum speed of the target ** IN KM/H **
     
    public float minSpeedAngle;//MinSpeedAngle = 1.414
    public float maxSpeedAngle;//MaxSpeedAngle = -257.21

    [Header("Insert Spd and Gauge")]
    public Text Spd; // The label that displays the speed;
    public RectTransform Guage; // The gauge in the speedometer

    private float speed = 0.0f;
    private void Update()
    {
        // 3.6f to convert in kilometers
        // ** The speed must be clamped by the car controller **
        speed = Car.velocity.magnitude * 3.6f;

        if (Spd != null)
            Spd.text = ((int)speed) + " km/h";
        if (Guage != null)
            Guage.localEulerAngles =
                new Vector3(0, 0, Mathf.Lerp(minSpeedAngle, maxSpeedAngle, speed / maxSpeed));
    }
}
