using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadObject : MonoBehaviour
{

   // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

  
        public void Play()
       {
          SceneManager.LoadScene (2);  

       }
    
}
