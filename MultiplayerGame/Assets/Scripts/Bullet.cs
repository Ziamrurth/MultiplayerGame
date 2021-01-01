using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;

    void Move() {
        transform.position += transform.up * Time.deltaTime * speed;
    }

    void Update()
    {
        Move();
    }
}
