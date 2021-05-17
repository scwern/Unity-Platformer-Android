using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shoot;
    public float timeShoot = 2f;
    public AudioSource shootS;
    // Start is called before the first frame update
    void Start()
    {
        shoot.transform.position = new Vector3(transform.position.x - 1f, transform.position.y - 1f, transform.position.z);
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
        shootS.Play();
        StartCoroutine(Shooting());
    }
}
