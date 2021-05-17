using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public static bool mus;
    // Start is called before the first frame update
    void Start()
    {
        
        if (mus == false)
        {
            GetComponent<AudioSource>().Play();
            mus = true;
            //GetComponent<AudioSource>().Play();
        // GameObject.Find("Music").SetActive(true);
         }
        else 
        {
          
        GetComponent<AudioSource>().Stop();
        //Destroy(this.gameObject);

        }




    }

            void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        // SceneManager.sceneLoaded += OnSceneLoaded;
    }

    
}
