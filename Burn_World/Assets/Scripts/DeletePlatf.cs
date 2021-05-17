using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlatf : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("hero"))
        {
            Invoke("FallPlatform", 1.5f);
            Destroy(gameObject, 2f);

        }
    }
        void FallPlatform() 
        {
            rb.isKinematic = false;
        }

        // Update is called once per frame
    
}
