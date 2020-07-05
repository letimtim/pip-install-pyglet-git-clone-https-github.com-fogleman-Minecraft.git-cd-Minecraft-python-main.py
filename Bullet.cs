using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    public float bulletSpeed;
    [SerializeField]
    public GameObject target;
    [SerializeField]
    public int damage;
    [SerializeField]
    public float bulletLifeSpan;
    [SerializeField]
    public float timeAlive = 0.0f;
    [SerializeField]
   
   
  


    private float currentHealth;

    public HealthSystem healthSystem1;

    private void Start()
    {
       
    } 

    private void Update()
    {        
      transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);

      timeAlive += Time.deltaTime;

        if(timeAlive > bulletLifeSpan)
        {
           Destroy(this.gameObject);
        }

      
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
            target = other.gameObject;
           
            target.GetComponent<HealthSystem>().playerHealth -= damage ;
            
            Destroy(gameObject);
            if (target.GetComponent<HealthSystem>().playerHealth < 0)
            {
                target.transform.position = new Vector3(0.19f, 2.4f, 53.8f);
                target.GetComponent<HealthSystem>().playerHealth = 100;
            }

        }
    }

    private void Reset1()
    {
          
        
    }
}
