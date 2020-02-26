using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScriptAlt : MonoBehaviour
{
    public ActiveObjectScript actObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name.Equals("Character")&&Input.GetKeyDown(KeyCode.X))
        {
            actObj.isActive = !actObj.isActive;
        }
    }
}
