using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedButtonScript : MonoBehaviour
{
    public float timer;
    public GameObject otherObj;
    bool isOtherActive;
    public float activatingTime;
    public GameObject leverKol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Time.time>=activatingTime)
        {
            otherObj.SetActive(true);
            isOtherActive=true;
            leverKol.transform.rotation = Quaternion.Euler(45, 0, 45);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name.Equals("Character") && Input.GetKeyDown(KeyCode.X))
        {
            otherObj.SetActive(false);
            isOtherActive = false;
            activatingTime = Time.time + timer;
            leverKol.transform.rotation = Quaternion.Euler(45, 180, 45);

        }
    }
}
