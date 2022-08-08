   
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraForCar: MonoBehaviour
{
    [SerializeField] private float transSpeed;
    [SerializeField] private float rotSpeed;
 
    [SerializeField] private Vector3 viewpoint;
    [SerializeField] private Transform car;
    
 // Viewpoint for camera (x(2.22),y(6.38),z(22.2)) to be adjusted when played 
    private void FixedUpdate()
    {
        Translation();
        Rotation();
    }
   
   private void Rotation()
    {
        var direction = car.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotSpeed * Time.deltaTime);
    }
    private void Translation()
    {
        var carPosition = car.TransformPoint(viewpoint);
        transform.position = Vector3.Lerp(transform.position, carPosition, transSpeed * Time.deltaTime);
    }

}
