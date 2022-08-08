
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float steerAngle;
    private bool Breaking;
   
    public Transform FLWheelTrans;
    public Transform FRWheelTrans;
    

    public WheelCollider FLWheelCollider;
    public WheelCollider FRWheelCollider;
    public WheelCollider RLWheelCollider;
    public WheelCollider RRWheelCollider;

    public float maxSteeringAngle = 30f;
    public float motorForce = 50f;
    public float brakeForce = 10f;


    private void FixedUpdate()
    {
        GetInput();
        GetMotor();
        GetSteering();
        UpdateWheels();
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Breaking = Input.GetKey(KeyCode.Space);
        
    }

    private void GetSteering()
    {
        steerAngle = maxSteeringAngle * horizontalInput;
        FLWheelCollider.steerAngle = steerAngle;
        FRWheelCollider.steerAngle = steerAngle;
    }

    private void GetMotor()
    {
        //Calling funtions for wheel collider and linking the fuction motortorque to enable the movement of the car
        FLWheelCollider.motorTorque = verticalInput * motorForce;
        FRWheelCollider.motorTorque = verticalInput * motorForce;
        RRWheelCollider.motorTorque = verticalInput * motorForce;
        RLWheelCollider.motorTorque = verticalInput * motorForce;

       //to determine the stopping time for the car to stop the higher the f is the faster the car will stop
        brakeForce = Breaking ? 8000f : 0f;

        FLWheelCollider.brakeTorque = brakeForce;
        FRWheelCollider.brakeTorque = brakeForce;
        RLWheelCollider.brakeTorque = brakeForce;
        RRWheelCollider.brakeTorque = brakeForce;
    }

    private void UpdateWheels()
    {
        UpdateWheelPos(FLWheelCollider, FLWheelTrans);
        UpdateWheelPos(FRWheelCollider, FRWheelTrans);
    }



    private void UpdateWheelPos(WheelCollider wheelCollider, Transform trans)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        // taking the rot return of the wheel collider and add 90 degrees to the y axis so the wheel does not rotate the wrong way
         rot = rot * Quaternion.Euler(new Vector3(0, 0, 90));
        print(rot);
        trans.rotation = rot;
        trans.position = pos;
    }

}

