using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour
{
    public GameObject leverStick;
    public GameObject myChangeAbleObstacle;
    public AudioSource play;
    bool isChanged = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Equals("Character")&&Input.GetKeyDown(KeyCode.X))
        {
            play.Play();
            if (isChanged == false)
            {
                //Debug.Log("Ding");
                myChangeAbleObstacle.transform.Translate(Vector3.forward * 8);
                myChangeAbleObstacle.SetActive(false);
                isChanged = true;
                leverStick.transform.RotateAroundLocal(Vector3.up, 180);
            }
            else
            {
                //Debug.Log("Dong");
                myChangeAbleObstacle.transform.Translate(Vector3.forward * -8);
                myChangeAbleObstacle.SetActive(true);
                isChanged = false;
                leverStick.transform.RotateAroundLocal(Vector3.up, -180);
            }
        }
    }
}
