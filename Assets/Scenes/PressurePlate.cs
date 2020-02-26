using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject activeObject;
    private bool isactive=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isactive)
        {
            activeObject.SetActive(false);
        }
        else
        {
            activeObject.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        isactive = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isactive = false;
    }
}
