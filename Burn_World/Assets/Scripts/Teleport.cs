using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public bool isOpen = true;
    public Transform port;
    public Sprite mid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unlock()
    {
        isOpen = true;
        GetComponent<SpriteRenderer>().sprite = mid;
    }
    public void TPort(GameObject player)
    {
        player.transform.position = new Vector3(port.position.x, port.position.y, player.transform.position.z);
    }
}
