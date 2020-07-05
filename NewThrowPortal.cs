using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewThrowPortal : MonoBehaviour
{
    [SerializeField]
    public GameObject leftPortal;
    [SerializeField]
    public GameObject rightPortal;
    [SerializeField]
    public AudioSource openPortal;
    [SerializeField]
    public AudioSource errorPortal;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            OpenPortal(leftPortal);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            OpenPortal(rightPortal);
        }
    }

    void OpenPortal(GameObject portal)
    {
        portal.GetComponent<NewPortalMechanics>().portalOpen = true;
        int x = Screen.width / 2;
        int y = Screen.height / 2;

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(x, y));

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            if(hit.transform.CompareTag("Portal Allowed"))
            {
                openPortal.Play();
                portal.transform.position = hit.point;
                portal.transform.rotation = Quaternion.LookRotation(hit.normal);
            }

            if(!hit.transform.CompareTag("Portal Allowed"))
            {
                errorPortal.Play();
            }
        }
    }
}
