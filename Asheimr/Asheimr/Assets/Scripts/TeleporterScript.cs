using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class TeleporterScript : MonoBehaviour

{

    public GameObject teleportDestination;

    //what is needed for this script 
    //needs to hit a teleporter gameobject with a tag called teleporter 
    // needs a gameobject to teleport to (and is referenced in this script) 
    //needs to be attached to player controller with some form of collider 

    private void OnCollisionEnter(Collision other)
    {

        //ensure to only teleporrt the player
        if (other.gameObject.tag == "Player")
        {
            //teleport player to the destination
            other.transform.position = teleportDestination.transform.position;
        }
    }
}