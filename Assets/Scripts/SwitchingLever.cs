using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingLever : MonoBehaviour
{
    public List<GameObject> objList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Equals("Character") && Input.GetKeyDown(KeyCode.X))
        {
            foreach(GameObject o in objList)
            {
                o.SetActive(!o.active);
            }
        }
    }
}
