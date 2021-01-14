using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class GunShooting : NetworkBehaviour {

    [SerializeField]
    GameObject bulletSpawnPoint;
    [SerializeField]
    GameObject bulletPrefab;
    
    //void Createbullet() {
    //    GameObject newBullet = Instantiate(bullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
    //    //NetworkServer.Spawn(newBullet);
    //}

    private void OnMouseDown() {
        Debug.Log("Click on gun");
        CmdSpawnBullet();
    }

    [Command(ignoreAuthority = true)]
    void CmdSpawnBullet()
    {
        if(bulletPrefab != null)
        {
            Debug.Log("Bullet spawned");
            GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
            NetworkServer.Spawn(newBullet);
        }
        else
        {
            Debug.Log("Prefab is null");
        }
    }

}
