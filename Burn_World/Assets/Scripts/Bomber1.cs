using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : MonoBehaviour
{
    public GameObject bullet;
    public Transform shoot;
    public float timeShoot = 2f;
    // Start is called before the first frame update
    void Start()
    {
        shoot.transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z);
        StartCoroutine(Shooting());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Shooting()
    {
        yield return new WaitForSeconds(timeShoot);
        Instantiate(bullet, shoot.transform.position, transform.rotation);

        StartCoroutine(Shooting());
    }
}
