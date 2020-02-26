using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObject : MonoBehaviour
{
    public Collider objCollider;
    public Renderer objRenderer;
    bool isactive ;
    public int timer;
    float remainingtime=0;
    // Start is called before the first frame update
    void Start()
    {
        isactive = objCollider.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= remainingtime)
        {
            isactive = !isactive;
            remainingtime =Time.time+timer;
        }

        if (isactive)
        {
            objCollider.enabled = true;
            objRenderer.enabled = true;
        }
        else
        {
            objCollider.enabled = false;
            objRenderer.enabled = false;
        }
    }
}
