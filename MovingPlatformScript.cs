using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
   
    //Making player the child of the moving platform 
    //Bug : Player sliding of the moving platform
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player entered"); // Debugging the colliders

        //Landing on the platfrom
        if (other.CompareTag("Player"))
        {
            player.transform.parent = transform; //Setting the platform as the parent of Player
        }
      
    }
    public void OnTriggerExit(Collider other)
    {
        //Exiting the platform 
        player.transform.parent = null; //Resetting the parent of the Player.
       
    }
}
