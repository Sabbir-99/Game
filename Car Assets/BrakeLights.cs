using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeLights : MonoBehaviour
{
    public GameObject Brake;
    // Start is called before the first frame update
    void Start()
    {
        Brake.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Brake.SetActive (true);
        }

        else 

    
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Brake.SetActive (false);
        }
    }
}
