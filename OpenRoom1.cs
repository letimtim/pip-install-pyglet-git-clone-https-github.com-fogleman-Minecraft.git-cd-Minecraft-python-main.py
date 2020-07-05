using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRoom1 : MonoBehaviour
{
    [SerializeField]
    public GameObject door;
    [SerializeField]
    public Light doorLight;
    [SerializeField]
    public Light mainDoorLight;
    [SerializeField]
    public AudioSource doorSound;
    [SerializeField]
    public AudioSource buttonSound;

    private Animator animator = null;

     void Start()
    {
        animator = door.GetComponent<Animator>();
        doorLight = doorLight.GetComponent<Light>();
        mainDoorLight = mainDoorLight.GetComponent<Light>();
    }

    public void OnTriggerEnter(Collider other)
    {
        doorSound.Play();
        animator.Play("Room1DoorOpen");
        doorLight.color = Color.green;
        mainDoorLight.color = Color.green;
    }

    public void OnTriggerExit(Collider other)
    {
        doorSound.Play();
        animator.Play("Room1DoorClose");
        doorLight.color = Color.red;
        mainDoorLight.color = Color.red;
    }
}

//Playing Animation via Using Animation Clip. Using Animator to access the different states. 
// Animation clips created using Transform position on 1 axis.
// Color changing helps in player Feedback/Game Feedback loop.
