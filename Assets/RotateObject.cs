using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotateObject : MonoBehaviour
{

    public Vector3 RotateAmount;  // degrees per second to rotate in each axis. Set in inspector.

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ADS");
        transform.Rotate(RotateAmount * Time.deltaTime);
    }
}
