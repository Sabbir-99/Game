using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    // Used to render the car 
    public Renderer carRenderer;
    public Renderer carbody2Renderer;
    public Renderer Spoilerrenderer;
    public Renderer car2Renderer;
    public Renderer Body2Renderer;
    public Renderer Spoilerrrenderer;

    public GameObject car2;
    public GameObject Body2;
    public GameObject car;
    public GameObject carbody2;
    public GameObject Spoiler;
    public GameObject Spoilerrr;
    
    // For List of colours
    [SerializeField] private Color[] Colourchange;
    [SerializeField] private Color SelectColor;
    private int colourValue; 
    // Start is called before the first frame update
    void Start()
    {
        // getting the renderer componenets for the car
        carRenderer = car.GetComponent<Renderer>();
        car2Renderer = car2.GetComponent<Renderer>();
        carbody2Renderer = carbody2.GetComponent<Renderer>();
        Body2Renderer = Body2.GetComponent<Renderer>();
        Spoilerrenderer = Spoiler.GetComponent<Renderer>();
        Spoilerrrenderer = Spoilerrr.GetComponent<Renderer>();
    }

    
    public void ChangeColors(){
    //This will allow the  colour to change when the button is clicked 
    SelectColor = Random.ColorHSV();

    carRenderer.material.color = SelectColor;
    car2Renderer.material.color = SelectColor;
    carbody2Renderer.material.color = SelectColor;
    Body2Renderer.material.color = SelectColor;
    Spoilerrenderer.material.color = SelectColor;
    Spoilerrrenderer.material.color = SelectColor;
}
}
