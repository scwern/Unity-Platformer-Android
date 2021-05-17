using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Next", 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Next()
    {
        SceneManager.LoadScene(2);
    }
}
