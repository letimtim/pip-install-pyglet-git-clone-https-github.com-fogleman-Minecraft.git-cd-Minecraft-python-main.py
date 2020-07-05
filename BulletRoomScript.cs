using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletRoomScript : MonoBehaviour
{
    [SerializeField]
    public Text warning;

    private void OnTriggerEnter(Collider other)
    {
        warning.gameObject.SetActive(true);
        warning.CrossFadeAlpha(0f, 10f, ignoreTimeScale: false);
    }
}
