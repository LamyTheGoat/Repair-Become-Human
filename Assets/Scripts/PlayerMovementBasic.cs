using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBasic : MonoBehaviour
{
    public GameManagerScript gameManagerScript;
    public float walkingSpeed;
    public Transform grndcheck;
    public float grndDistance;
    public LayerMask groundMask;
    public float jumpForce;
    public float hInput;
    public string state;
    public float crawlForce;
    public Rigidbody rb;
    public float pullRate;




    private float nextTimeToForce = 0f;
    public bool isGrounded;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(grndcheck.position, grndDistance, groundMask);
        if (gameManagerScript.gameHasEnded != true)
            Move();
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
           
        }
    }   





    //HANGI HAREKETIN YAPILACAGINA KARAR VERME/ DECIDING MOVEMENT STYLE
    public void Move()
    {
        switch (state)
        {
            case "dragmove":
                DragMovement();
                //jumpForce = 15;
                break;
            case "crawlmoveR":
                jumpForce = 0;
                CrawlMovementR();
                break;
            case "crawlmoveLR":
                CrawlMovementLR();
                //jumpForce = 5;
                break;
            case "crawlmoveL":
                CrawlMovementL();
                jumpForce = 0;
                break;
        }
        Jump();
        SelfDestruct();
    }


    //ZIPLAMA/JUMP
    public void Jump()
    {
        if (Input.GetButton("Jump") && isGrounded)
        {
            //Debug.Log("Zıp");
            rb.AddForce(Vector3.up * jumpForce * 10);
        }

    }



    //NORMAL HAREKET/ DEFAULT MOVEMENT
    public void DragMovement()
    {
        hInput = Input.GetAxis("Horizontal");
        float vMovement = hInput * walkingSpeed;
        rb.velocity = new Vector3(vMovement, rb.velocity.y, 0);
    }



    //SÜRÜNEREK İLERLEME SAĞ / MOVING VIA CRAWLING RIGHT
    public void CrawlMovementR()
    {

        if (Input.GetKey(KeyCode.D) && Time.time >= nextTimeToForce)
        {
            nextTimeToForce = Time.time + 1f / pullRate;

            hInput = Input.GetAxis("Horizontal");
            Vector3 vMovement = (transform.right * hInput) * Time.deltaTime * walkingSpeed;

            rb.AddForce(Vector3.right * walkingSpeed * crawlForce);
            transform.Translate(vMovement);

        }

    }

    //SÜRÜNEREK ILERLEMEK GENEL / MOVING VIA CRAWLING BOTH DIRECTIONS 
    public void CrawlMovementLR()
    {

        if (Input.GetKey(KeyCode.D) && Time.time >= nextTimeToForce)
        {
            nextTimeToForce = Time.time + 1f / pullRate;

            hInput = Input.GetAxis("Horizontal");
            Vector3 vMovement = (transform.right * hInput) * Time.deltaTime * walkingSpeed;

            rb.AddForce(Vector3.right * walkingSpeed * crawlForce);
            transform.Translate(vMovement);

        }

        if (Input.GetKey(KeyCode.A) && Time.time >= nextTimeToForce)
        {
            nextTimeToForce = Time.time + 1f / pullRate;

            hInput = Input.GetAxis("Horizontal");
            Vector3 vMovement = (transform.right * hInput) * Time.deltaTime * walkingSpeed*-1;

            rb.AddForce(Vector3.right * walkingSpeed * crawlForce*-1);
            transform.Translate(vMovement);

        }

    }

    //SÜRÜNEREK İLERLEME SOL / MOVING VIA CRAWLING LEFT
    public void CrawlMovementL()
    {

        if (Input.GetKey(KeyCode.A) && Time.time >= nextTimeToForce)
        {
            nextTimeToForce = Time.time + 1f / pullRate;

            hInput = Input.GetAxis("Horizontal");
            Vector3 vMovement = (transform.right * hInput) * Time.deltaTime * walkingSpeed*-1;

            rb.AddForce(Vector3.right * walkingSpeed * crawlForce*-1);
            transform.Translate(vMovement);

        }

    }

    void SelfDestruct()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameManagerScript.EndGame();
        }
    }
}
