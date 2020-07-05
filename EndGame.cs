using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    public Light doorlight;
    [SerializeField]
    public GameObject door;

    public Animator animator = null;

    private void Start()
    {
        doorlight = doorlight.GetComponent<Light>();
        animator = door.GetComponent<Animator>();
    }

    private void Update()
    {
        if(doorlight.color == Color.green)
        {
            //PLay Animation
        }
    }
}
