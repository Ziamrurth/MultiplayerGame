using Cinemachine;
using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : NetworkBehaviour {

    [SerializeField]
    float speedScale = 1f;

    float moveHorizontal = 0;
    float moveVertical = 1;

    [SerializeField]
    CinemachineVirtualCamera mainCamera;

    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            Vector3 movement = new Vector3(moveHorizontal * speedScale * Time.deltaTime, moveVertical * speedScale * Time.deltaTime, 0);
            transform.position += movement;
        }
    }

    void RandomiseMovement()
    {
        float angle = Random.Range(0f, 360f);
        moveVertical = Mathf.Sin(angle);
        moveHorizontal = Mathf.Cos(angle);
    }

    void MountCamera()
    {
        if (isLocalPlayer)
        {
            mainCamera = GameObject.Find("CameraController").GetComponent<CameraController>().mainVirtualCamera;

            mainCamera.LookAt = transform;
            mainCamera.Follow = transform;
        }
    }

    void Start()
    {
        MountCamera();
        //RandomiseMovement();
    }

    void Update()
    {
        HandleMovement();
    }

    private void OnMouseDown()
    {
        if (isLocalPlayer)
        {
            RandomiseMovement();
        }
    }
}
