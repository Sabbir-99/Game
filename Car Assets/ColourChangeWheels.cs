using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChangeWheels : MonoBehaviour
{
    // Used to render the car 
    public Renderer BLWheelrenderer;
    public Renderer FrontRightWheelrenderer;
    public Renderer FLWheelrenderer;
    public Renderer BRWheelrenderer;
    public Renderer MainFRWheelrenderer;
    public Renderer MainBRWheelrenderer;
    public Renderer MainFLWheelrenderer;
    public Renderer MainRLWheelrenderer;


    public GameObject FrontLeftWheel;
    public GameObject FrontRightWheel;
    public GameObject RearRightWheel;
    public GameObject RearLeftWheel;
    public GameObject FrontRightWheel2;
    public GameObject RearRightWheel2;
    public GameObject FrontLeftWheel2;
    public GameObject RearLeftWheel2;


    // For List of colours
    [SerializeField] private Color[] Colourchange;
    [SerializeField] private Color SelectColor;
    private int colourValue; 
    // Start is called before the first frame update
    void Start()
    {
        // getting the renderer componenets for the car
        FrontRightWheelrenderer = FrontRightWheel.GetComponent<Renderer>();
        FLWheelrenderer = FrontLeftWheel.GetComponent<Renderer>();
        BRWheelrenderer = RearRightWheel.GetComponent<Renderer>();
        BLWheelrenderer = RearLeftWheel.GetComponent<Renderer>();
        MainFRWheelrenderer = FrontRightWheel2.GetComponent<Renderer>();
        MainBRWheelrenderer = RearRightWheel2.GetComponent<Renderer>();
        MainFLWheelrenderer = FrontLeftWheel2.GetComponent<Renderer>();
        MainRLWheelrenderer = RearLeftWheel2.GetComponent<Renderer>();
        
    }

    
    public void ChangeColors(){
    //This will allow the  colour to change when the button is clicked 
    SelectColor = Random.ColorHSV();

    FrontRightWheelrenderer.material.color = SelectColor;
    FLWheelrenderer.material.color = SelectColor;
    BRWheelrenderer.material.color = SelectColor;
    BLWheelrenderer.material.color = SelectColor;
    MainFRWheelrenderer.material.color = SelectColor;
    MainBRWheelrenderer.material.color = SelectColor;
    MainFLWheelrenderer.material.color = SelectColor;
    MainRLWheelrenderer.material.color = SelectColor;
}
}
