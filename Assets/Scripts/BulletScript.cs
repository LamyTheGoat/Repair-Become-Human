using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float spd = 20f;
    public Rigidbody rb;
    //public GameManagerScript gm;
    public float bulletDissappearTime;
    float destroyTime;
    void Start()
    {
        rb.velocity = transform.right * spd;
        destroyTime = Time.time+4;
    }
    private void Update()
    {
        if (Time.time >= destroyTime)
            Destroy(gameObject);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Character"))
        {
            PlayerMovementBasic pmb = other.GetComponent<PlayerMovementBasic>();
            pmb.gameManagerScript.EndGame();
            Destroy(gameObject);
        }
        if (other.name.Equals("Moveable_cube"))
        {
            Destroy(gameObject);

        }
    }
}
