using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTriggerScript : MonoBehaviour
{
    public GameObject thisPlatform;
    public Vector3 thisBalancePosition;
    public Vector3 thisDownPosition;

    public GameObject otherPlatform;



    public GameObject thisCollided=null;
    public ScaleTriggerScript otherCollisionScript;

    public float speed;

    void Start()
    {
        thisBalancePosition = transform.position;
    }

    
    void Update()
    {
        if (thisCollided != null && otherCollisionScript.thisCollided == null)
        {
            //Debug.Log("Ding Üstümde Bir Şey Var");
            Vector3 direction = (Vector3)(thisDownPosition - thisPlatform.transform.position).normalized;
            if (Mathf.Abs(thisDownPosition.y - thisPlatform.transform.position.y) >= 0.1)
            {
                thisPlatform.transform.Translate(direction * Time.deltaTime * speed);
                otherPlatform.transform.Translate(direction * Time.deltaTime * speed*-1);
            }
            else
            {
                thisPlatform.transform.position = thisDownPosition;
            }
        }
        else if(thisCollided == null && otherCollisionScript.thisCollided != null)
        {

        }
        else if (thisCollided != null && otherCollisionScript.thisCollided != null)
        {

        }
        else
        {
            if (Mathf.Abs(thisBalancePosition.y - thisPlatform.transform.position.y) >= 0.1)
            {
                Vector3 direction = (Vector3)(thisBalancePosition - thisPlatform.transform.position).normalized;
                thisPlatform.transform.Translate(direction * Time.deltaTime * speed);
            }
            else
            {
                thisPlatform.transform.position = thisBalancePosition;
            }
        }
    }

    public void OnTriggerStay(Collider other)
    {
        //Debug.Log("Ding Üstümde Bir Şey Var!!!");
        thisCollided = other.gameObject;

    }
    public void OnTriggerExit(Collider other)
    {
        thisCollided = null;
    }
}
