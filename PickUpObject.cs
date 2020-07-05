using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    [SerializeField]
    GameObject mainCamera;
    [SerializeField]
    bool isCarrying = false;
    [SerializeField]
    GameObject carriedObject;
    [SerializeField]
    float distance = 2.0f;
    [SerializeField]
    float smooth = 5.0f;
    [SerializeField]
    float distanceToBePickedFrom;
    
    void Update()
    {
        if (isCarrying)
        {
            carry(carriedObject);
            checkDrop();
        }
        else
        {
            pickItUp();
        }
    }

    void carry(GameObject Object)
    {
        // object transform, camera transform + forward * distance, time * smooth
        Object.transform.position = Vector3.Lerp(Object.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);

    }

    void pickItUp()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Find out the middle of the screen where our ray will hit the object.
            int x = Screen.width / 2;
            int y = Screen.height / 2;
            //RayCast Physics.
            // Hit Collider
            Ray pickUpRay = Camera.main.ScreenPointToRay(new Vector3(x, y)); // Middle of the screen!!!
            RaycastHit hit;

            if(Physics.Raycast(pickUpRay, out hit))
            {
                distanceToBePickedFrom = hit.distance;
                if (distanceToBePickedFrom < 5)
                {
                    CanBePicked a = hit.collider.GetComponent<CanBePicked>();
                    if (a != null)
                    {
                        isCarrying = true;
                        carriedObject = a.gameObject;
                        a.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    }
                }
            }
        }
    }
    void checkDrop()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            dropObject();
        }
    }

    void dropObject() // Inversing all the things from the PickUp function
    {
        isCarrying = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        carriedObject = null;
    }
}
