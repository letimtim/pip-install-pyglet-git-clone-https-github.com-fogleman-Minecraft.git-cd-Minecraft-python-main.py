using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRoom1 : MonoBehaviour
{
    [SerializeField]
    public GameObject door;

    [SerializeField]
    public Light consoleLight;

    [SerializeField]
    public Light doorLight;

    [SerializeField]
    public Light mainDoorlightroom2; //Main Light Door Scene Door 2 

    private Animator animator = null;

    [SerializeField]
    public AudioSource button;

    void Start()
    {
        animator = door.GetComponent<Animator>();
        consoleLight = consoleLight.GetComponent<Light>();
        doorLight = doorLight.GetComponent<Light>();
        mainDoorlightroom2 = mainDoorlightroom2.GetComponent<Light>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        button.Play();
        Debug.Log("Player Entered");
        consoleLight.color = Color.green;
        animator.Play("Room3Open");
        doorLight.color = Color.green;
        mainDoorlightroom2.color = Color.green;
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Player Entered");
        consoleLight.color = Color.red;
        animator.Play("Room3Close");
        doorLight.color = Color.red;
        mainDoorlightroom2.color = Color.red; // Accessing the main door Light throught the switch circle.
    }
}
