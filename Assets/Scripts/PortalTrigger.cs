using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{
    public GameObject otherPortal;
    public GameObject player;



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name.Equals("Character") && Input.GetKeyDown(KeyCode.X))
        {
            player.transform.position = new Vector3(otherPortal.transform.position.x,otherPortal.transform.position.y,other.transform.position.z);
        }
    }
}
