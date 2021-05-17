using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject drotik;
    public Transform startShoot;
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Shoots();
        StartCoroutine(Waiting());
    }

    void Shoots()
    {
        Instantiate(drotik, startShoot.position, startShoot.rotation);
    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(waitTime);
    }
}
