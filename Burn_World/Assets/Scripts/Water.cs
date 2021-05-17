using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            timer = 0;
            transform.localScale = new Vector3(-1f, 1f, 1f);
        } else if (timer >= 0.5f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
