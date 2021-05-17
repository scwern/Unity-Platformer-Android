using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlyPLPL : MonoBehaviour
{
   
   // [SerializeField]
    public Transform left, right;
    //private GameObject hero;
    Player player;

    private void Start()
    {
        player = GameObject.Find("hero").GetComponent<Player>();
        //player = hero.GetComponent<Player>();
        
        
       
    }



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            RaycastHit2D leftWall = Physics2D.Raycast(left.position, Vector2.left, 0.5f);
            RaycastHit2D rightWall = Physics2D.Raycast(right.position, Vector2.right, 0.5f);
            if ((player.directionInput > 0) && !rightWall.collider && (collision.transform.position.x > transform.position.x))
            
             transform.position = new Vector3(collision.transform.position.x, transform.position.y, transform.position.z);
            else if ((player.directionInput < 0) && !leftWall.collider && (collision.transform.position.x < transform.position.x))
                     transform.position = new Vector3(collision.transform.position.x, transform.position.y, transform.position.z);
        }
    }



}
