using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    
    public float speedScale = 1f;

    float moveHorizontal = 0;
    float moveVertical = 1;

    private CinemachineVirtualCamera mainCamera;

    private void FixedUpdate()
    {
        //SendInputToServer();
    }

    //void handlemovement()
    //{
    //    vector3 movement = new vector3(movehorizontal * speedscale * time.deltatime, movevertical * speedscale * time.deltatime, 0);
    //    transform.position += movement;
    //}

    //void randomisemovement()
    //{
    //    float angle = random.range(0f, 360f);
    //    movevertical = mathf.sin(angle);
    //    movehorizontal = mathf.cos(angle);
    //}

    void MountCamera()
    {
        mainCamera = GameObject.Find("CameraController").GetComponent<CameraController>().mainVirtualCamera;

        mainCamera.LookAt = transform;
        mainCamera.Follow = transform;
    }

    void Start()
    {
        MountCamera();
        //RandomiseMovement();
    }

    private void OnMouseDown()
    {
        SendInputToServer();
        //RandomiseMovement();
    }

    private void SendInputToServer()
    {
        bool[] _inputs = new bool[]
        {
            true
        };

        ClientSend.PlayerMovement(_inputs);
    }
}
