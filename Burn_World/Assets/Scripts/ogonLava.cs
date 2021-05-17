using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ogonLava : MonoBehaviour
{
    Rigidbody2D rb;
    public float power;
    public float TimeToDisable = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * power;
        StartCoroutine(SetDisabled());

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SetDisabled()
    {
        yield return new WaitForSeconds(TimeToDisable);
        Destroy(gameObject, 0.6f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag == "Player")
        {
            rb.isKinematic = true;
        }
    }
}
