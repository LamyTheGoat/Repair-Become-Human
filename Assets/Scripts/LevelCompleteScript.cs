using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteScript : MonoBehaviour
{

    public float rSpd;
    public GameManagerScript gameManager;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.gameObject.name.Equals("Character"))
        {
            gameManager.CompleteLevel();
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.RotateAroundLocal(Vector3.right,rSpd*Time.deltaTime);
    }
}
