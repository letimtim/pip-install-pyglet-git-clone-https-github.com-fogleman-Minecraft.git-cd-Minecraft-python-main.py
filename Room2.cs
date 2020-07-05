using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2 : MonoBehaviour
{
    [SerializeField]
    public Light consoleLight;
    [SerializeField]
    public GameObject room3door;
    [SerializeField]
    public Light mainDoorLight;
    [SerializeField]
    public Light doorLight;
    [SerializeField]
    public AudioSource button;
    private Animator animator = null;
    // Start is called before the first frame update
    void Start()
    {
        consoleLight = consoleLight.GetComponent<Light>();
        animator = room3door.GetComponent<Animator>();
        mainDoorLight = mainDoorLight.GetComponent<Light>();
        doorLight = doorLight.GetComponent<Light>();
    }

    private void OnTriggerEnter(Collider other)
    {
        button.Play();
        animator.Play("Room2DoorOpen");
        consoleLight.color = Color.green;
        mainDoorLight.color = Color.green;
        doorLight.color = Color.green;
    }

    private void OnTriggerExit(Collider other)
    {
        animator.Play("Room2DoorClose");
        consoleLight.color = Color.red;
        mainDoorLight.color = Color.red;
        doorLight.color = Color.red;
    }
}
