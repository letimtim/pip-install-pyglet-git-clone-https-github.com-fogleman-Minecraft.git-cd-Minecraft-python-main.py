using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    public float playerHealth;
    [SerializeField]
    public GameObject player;
    [SerializeField]
    public Image blood1;
    [SerializeField]
    public Image blood2;
    [SerializeField]
    public bool fblood = false;
    [SerializeField]
    public bool sblood = false;
    



  public  void Update()
    {
      if(playerHealth < 0)
      {
            Respawn();
      }  
      
      if(sblood == true)
        {
            Debug.Log("Blood2");
            blood2.gameObject.SetActive(true);
            blood2.CrossFadeAlpha(0f, 2f, ignoreTimeScale: false);
            Invoke("image2", 3f);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet" && playerHealth >0)
        {
            sblood = true;
        }
        
    }

    void Respawn()
    {
        Debug.Log("Health is now Zero");
       
    }
    

    void image2()
    {
        blood2.gameObject.SetActive(false);
        sblood = false;
    }
}
