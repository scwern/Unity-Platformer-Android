using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawRot : MonoBehaviour
{
    //[SerializeField]
    //private float bubbleRotateSpeed;

    Quaternion rotationZ;

    private void Start()
    {

    }

    void FixedUpdate()
    {

        Rotation();
    }

    private void Rotation()
    {
        rotationZ = Quaternion.AngleAxis(1, new Vector3(0, 0, 1));
        transform.rotation *= rotationZ;
    }
}