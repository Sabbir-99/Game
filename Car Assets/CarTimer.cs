using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarTimer : MonoBehaviour
{

public float Timeremaining;
private bool TimerStart = false;

// 
public Text Timer;

 void Start()
 
  {

   TimerStart = true;
}

 void Update() 
 
 {
   // check if timer greater than 0 if not set the timer back to false
   if(TimerStart)
   {
      if(Timeremaining > 0)
      {
         Timeremaining -= Time.deltaTime;
         // calling the method to link with funtion 
         updateTime(Timeremaining);
      }

      else
      {
        Debug.Log("Time has run out");
        Timeremaining = 0;
        TimerStart = true;
      }
   }
}
void updateTime(float currentTime)
{
   // increment current time by 1 second
   currentTime += 1;
   // Minutes divide the current time by 60
   float minutes = Mathf.FloorToInt(currentTime / 60);
   // seconds use modulo to create seconds
   float seconds = Mathf.FloorToInt(currentTime % 60);

// display when the timer is running
   Timer.text = string.Format("{0:00} : {1:00}" , minutes ,seconds);

}
   }

