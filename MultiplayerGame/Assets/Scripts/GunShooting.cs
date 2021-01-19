using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour {
    
    public GameObject bulletSpawnPoint;
    public GameObject bulletPrefab;
    
    private void OnMouseDown() {
        Debug.Log("Click on gun");
        CmdSpawnBullet();
    }
    
    void CmdSpawnBullet()
    {
        if(bulletPrefab != null)
        {
            Debug.Log("Bullet spawned");
            GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
        }
        else
        {
            Debug.Log("Prefab is null");
        }
    }

}
