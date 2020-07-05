using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(2);
    }
}
