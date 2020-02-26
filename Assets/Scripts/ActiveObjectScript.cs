using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObjectScript : MonoBehaviour
{
    public bool isActive;
    public Vector3 notActivePos;
    public Vector3 activePos;
    public float spd;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            transform.Translate(Vector3.Normalize(activePos - transform.position) * spd * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.Normalize(notActivePos - transform.position) * spd * Time.deltaTime);
        }
    }
}
