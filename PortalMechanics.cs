using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMechanics : MonoBehaviour
{
    [SerializeField]
    public GameObject otherPortal;

    

    [SerializeField]
    public Transform playerCurrentPos;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("RRR");
        if (other.CompareTag("Player"))
        {
           Debug.Log("DETECTED");
            other.transform.position = otherPortal.transform.position + other.transform.forward * 2;
            other.transform.rotation = otherPortal.transform.rotation;
            
            //
        }
    }
}
