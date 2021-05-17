﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeetleA : MonoBehaviour
{
    public float speed = 4f;
    bool isWait = false;
    bool isHidden = false;
    public float waitTime = 4f;
    public Transform point;
    
    // Start is called before the first frame update
    void Start()
    {
        point.transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isWait == false)

            transform.position = Vector3.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
        if (transform.position == point.position)
        {
            if (isHidden)
            {
                point.transform.position = new Vector3(transform.position.x, transform.position.y + 6f, transform.position.z);
                isHidden = false;
                
            }
            else
            {
                point.transform.position = new Vector3(transform.position.x, transform.position.y - 6f, transform.position.z);
                isHidden = true;
                
            }

            isWait = true;
            StartCoroutine(Waiting());
        }
        

    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(waitTime);
        isWait = false;
        
    }
}