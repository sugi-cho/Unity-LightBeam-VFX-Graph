using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float angle = 45f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * angle * Time.deltaTime, Space.Self);
    }
}
