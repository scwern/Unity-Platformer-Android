using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SgystokParts : MonoBehaviour
{
    [SerializeField]
    Vector2 forceDir;
    [SerializeField]
    int spin;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(forceDir);
        rb.AddTorque(spin); // вращение
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
