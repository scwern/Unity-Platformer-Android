using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().RecountHp(-1);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 0f, ForceMode2D.Impulse);
        }
    }
   public IEnumerator Death()
    {
        GetComponent<Animator>().SetBool("Death", true);
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        GetComponent<Collider2D>().enabled = false;
        GetComponentInChildren<Collider2D>().enabled = false;//нужно обращение к конкретному объекту, если дочерних больше одного.
        //transform.GetChild(0).GetComponent<Collider2D>().enabled = false; 0 - индекс элемента по подярку.
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
    public void startDeath()
    {
        StartCoroutine(Death());
    }
}
