using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEn : MonoBehaviour
{
    public float speed;
    private Transform target;
    Rigidbody2D rb;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}