using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject shotPrefab;
    public Transform[] gunPoints;
    public float fireRate;

    bool firing;
    float fireTimer;

    int gunPointIndex;

    private void Start()
    {
        StartCoroutine(Shoot());
    }

   // void Update()
    //{
    //    if (firing)
    //    {
    //        while (fireTimer >= 1 / fireRate)
    //        {
    //            SpawnShot();
    //            fireTimer -= 1 / fireRate;
    //        }

    //        fireTimer += Time.deltaTime;
    //        //firing = false;
    //    }
    //    else
    //    {
    //        if (fireTimer < 1 / fireRate)
    //        {
    //            fireTimer += Time.deltaTime;
    //        }
    //        else
    //        {
    //            fireTimer = 1 / fireRate;
    //        }
    //    }
    //}

    void SpawnShot()
    {
        
        var gunPoint = gunPoints[0];
        gunPoint.LookAt(GameManager.gameManager.player.transform);
        var bullet=Instantiate(shotPrefab, gunPoint.position, gunPoint.rotation);
        var ballet= GameManager.gameManager.player.transform.position+GameManager.gameManager.player.transform.forward*-5;
        bullet.transform.LookAt(ballet);
        gunPointIndex %= gunPoints.Length;
    }

    public void Fire()
    {
        firing = true;
    }
    public IEnumerator Shoot()
    {
        while (true)
        {
            SpawnShot();
            yield return new WaitForSeconds(fireRate);
        }
        
        
    }
}
