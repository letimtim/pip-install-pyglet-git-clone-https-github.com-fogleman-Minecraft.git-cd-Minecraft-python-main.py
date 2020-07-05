using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PitScript : MonoBehaviour
{
    [SerializeField]
    public Text pit;

    private void OnTriggerEnter(Collider other)
    {
        pit.gameObject.SetActive(true);
        pit.CrossFadeAlpha(0f, 20f, ignoreTimeScale: false);
    }
}
