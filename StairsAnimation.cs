using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsAnimation : MonoBehaviour
{
    [SerializeField]
    public GameObject stairs;
    [SerializeField]
    public AudioSource rampSound;
    [SerializeField]
    public AudioSource buttonSound;

    public Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        anim = stairs.GetComponent<Animator>(); // Getting the Animator from Stairs.
    }

    public void OnCollisionEnter(Collision collision)
    {
        buttonSound.Play();
        rampSound.Play();
        Debug.Log("Up Anim");
        anim.Play("RampUp"); // Play the Up animation
    }

    public void OnCollisionExit(Collision collision)
    {
        rampSound.Play();
        Debug.Log("Down Anim");
        anim.Play("RampDown"); // Play the Down animaton
    }
}
