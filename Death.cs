using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    [SerializeField]
    public GameObject box;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Invoke("Respawn", 1f);
    }

    void Respawn()
    {
        player.transform.position = new Vector3(17.77f ,2f,38.18f);
        box.transform.position = new Vector3(17.77f, 2f, 38.18f);
        Debug.Log("Reset");
    }
}
