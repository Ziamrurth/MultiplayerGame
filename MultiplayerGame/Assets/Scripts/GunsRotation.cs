using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsRotation : MonoBehaviour {

    float rotationSpeed = 20f;

    public void RotateOverTime()
    {
        transform.Rotate(Vector3.back * (rotationSpeed * Time.deltaTime));
    }

    void Update()
    {
        RotateOverTime();
    }
}
