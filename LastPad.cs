using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPad : MonoBehaviour
{
    [SerializeField]
    public Light mainDoorLight;
    [SerializeField]
    public GameObject endDoor;
    [SerializeField]
    public Light consoleLight;
    [SerializeField]
    public AudioSource button;

    private Animator animator = null;

    private void Start()
    {
        mainDoorLight = mainDoorLight.GetComponent<Light>();
        animator = endDoor.GetComponent<Animator>();
        consoleLight = consoleLight.GetComponent<Light>();
    }

    public void OnTriggerEnter(Collider other)
    {
        button.Play();
        animator.Play("EndGame");
        mainDoorLight.color = Color.green;
        consoleLight.color = Color.green;
    }

    public void OnTriggerExit(Collider other)
    {
        animator.Play("EndGameClose");
        mainDoorLight.color = Color.red;
        consoleLight.color = Color.red;
    }
}
