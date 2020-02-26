using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScriptTwoHand : MonoBehaviour
{
    public Animator anim;
    public GameObject body;
    float lastInput = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inp = Input.GetAxis("Horizontal");
        if (inp != 0)
        {
            anim.SetBool("isMoving", true);


        }
        else
        {
            anim.SetBool("isMoving", false);
        }
        if (inp > 0)
        {
            body.transform.rotation = Quaternion.Euler(0, 113, 0);
        }
        if (inp < 0)
        {
            body.transform.rotation = Quaternion.Euler(0, -80, 0);
        }
    }
}
