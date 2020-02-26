using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingCubeScript : MonoBehaviour
{
    public GameObject cube;
    public PlayerMovementBasic player;
    public Collider playerObj;
    public Collider thisObj;

    string oldstate;
    bool iscarried=false;
    private GameObject carryingArm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iscarried)
        {
            cube.transform.position = new Vector3(carryingArm.transform.position.x,carryingArm.transform.position.y,player.transform.position.z) + new Vector3(0, 0.3f, 0);
            if (Input.GetKeyDown(KeyCode.Z))
            {
                cube.transform.position= cube.transform.position + new Vector3(0, 0.3f, 0);
                iscarried = false;
                player.state = oldstate;
            }
            
        }
        Physics.IgnoreCollision(thisObj, playerObj, true);

    }
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.name);
        if ((other.name.Equals("LArm") || other.name.Equals("RArm")) && Input.GetKeyDown(KeyCode.F)&&iscarried==false){
            Debug.Log("Ding");
            if(other.name.Equals("LArm")){
                oldstate = player.state;
                if(oldstate.Equals("crawlmoveLR"))
                    player.state = "crawlmoveR";
                iscarried = true;

            }
            if (other.name.Equals("RArm")){
                Debug.Log("Sağ elimle tutuyorum");
                oldstate = player.state;
                if (oldstate.Equals("crawlmoveLR"))
                    player.state = "crawlmoveL";
                iscarried = true;

            }
            carryingArm = other.gameObject;
        }
        
    }
}
