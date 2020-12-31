using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : NetworkBehaviour {

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
