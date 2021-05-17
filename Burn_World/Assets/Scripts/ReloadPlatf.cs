﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadPlatf : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 currentPosition;
    bool moveingBack;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPosition = transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("hero") && moveingBack == false)
        {
            Invoke("FallPlatform", 1f);

        }
    }
    void FallPlatform()
    {
        rb.isKinematic = false;
        Invoke("BackPlatform", 1f);
    }

    void BackPlatform()
    {
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
        moveingBack = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveingBack == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, currentPosition, 20f * Time.deltaTime);
        }
        if (transform.position.y == currentPosition.y)
        {
            moveingBack = false;
        }
    }
}
