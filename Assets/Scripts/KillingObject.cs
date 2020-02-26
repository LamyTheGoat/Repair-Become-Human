using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingObject : MonoBehaviour
{
    public GameManagerScript gameManager;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Character"))
            gameManager.EndGame();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
