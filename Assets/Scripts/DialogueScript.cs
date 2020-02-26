using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    public GameObject text;

    bool isActive = false;

    // Update is called once per frame
    void Update()
    {
        text.SetActive(isActive);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Character"))
        {
            isActive = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("Character"))
        {
            isActive = false;
        }
    }
}
