using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class GunShooting : MonoBehaviour {

    [SerializeField]
    GameObject bulletSpawner;
    [SerializeField]
    GameObject bullet;
    
    void Createbullet() {
        GameObject newBullet = Instantiate(bullet, bulletSpawner.transform.position, bulletSpawner.transform.rotation);
        //NetworkServer.Spawn(newBullet);
    }

    private void OnMouseDown() {
        Createbullet();
    }

}
