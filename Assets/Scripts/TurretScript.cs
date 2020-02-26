using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public GameObject muzzle;
    public float fireRate;
    public GameObject bullet;
    float timeToFire = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1 / fireRate;
            Fire();
        }
    }

    void Fire()
    {
        Instantiate(bullet, muzzle.transform.position, muzzle.transform.rotation);
    }
}
