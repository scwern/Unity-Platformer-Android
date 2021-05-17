using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : MonoBehaviour
{
    Rigidbody2D rb;
    public float power;
    public float power1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * power + Vector2.right * -power;
       // rb.velocity = Vector2.up * power1 + Vector2.left * -power1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject, 1f);
    }
}
