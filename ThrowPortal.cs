using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPortal : MonoBehaviour
{
    [SerializeField]
    public GameObject PortalA;
    [SerializeField]
    public GameObject PortalB;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //LMB opens up the PortalA
        {
            OpenPortal(PortalA);
        }
        if (Input.GetMouseButtonDown(1)) //RMB opens up the PortalB
        {
            OpenPortal(PortalB);
        }
    }

    void OpenPortal(GameObject portal)
    {
        

        int x = Screen.width / 2;
        int y = Screen.height / 2;

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(x, y));

        RaycastHit hit;

        if(Physics.Raycast(ray,out hit))
        {
            if(hit.transform.CompareTag("Portal Allowed")) //Limiting the Portal to specific Walls
            {
                portal.transform.position = hit.point;
                portal.transform.rotation = Quaternion.LookRotation(hit.normal); // Portal will now Lie flat to the surface
            }
            else
            {
                Debug.Log("Error");
            }
            
        } 
        
    }
}
