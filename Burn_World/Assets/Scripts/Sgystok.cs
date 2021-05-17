using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sgystok : MonoBehaviour
{
    [SerializeField]
    Object destractable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Boom();
        }
    }

    void Boom()
    {
        GameObject destruct = (GameObject)Instantiate(destractable);
        destruct.transform.position = transform.position;

        Destroy(gameObject);
    }
}
