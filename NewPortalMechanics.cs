using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPortalMechanics : MonoBehaviour
{
    [SerializeField]
    public GameObject secondPortal;

    [SerializeField]
    public bool portalOpen = false;

    [SerializeField]
    public Transform currentPosPlayer;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && secondPortal.GetComponent<NewPortalMechanics>().portalOpen)  //checking if the first portal is open or not and also if the player is interacting with it.
        {
            Rigidbody otherRigidbody = other.GetComponent<Rigidbody>();

            Vector3 exitSpeed = secondPortal.transform.forward * otherRigidbody.velocity.magnitude; // adding the speed within the portal and setting the player to face forward when he exits the portal.
            otherRigidbody.velocity = exitSpeed; //Applying the speed to the player.

            other.transform.position = secondPortal.transform.position + secondPortal.transform.forward * 3; //Making the player spawn from the second portal.
        }
    }
}
