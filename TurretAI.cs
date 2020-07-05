using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurretAI : MonoBehaviour
{
    [SerializeField]
    private GameObject targetPlayer;
    [SerializeField]
    private bool playerFound;
    [SerializeField]
    public GameObject rotatingTurret;
    [SerializeField]
    public float delayFiring;
    [SerializeField]
    public bool readyBullet;
    [SerializeField]
    public GameObject bulletSpawn;
    [SerializeField]
    public GameObject bullet;
    [SerializeField]
    public ParticleSystem muzzleFlash;
    [SerializeField]
    public AudioSource bulletSound;
   

    private void Start()
    {
        
    }
    void Update()
    {
        if (playerFound)
        {
            Debug.Log("Target Located");
            rotatingTurret.transform.LookAt(targetPlayer.transform);
            rotatingTurret.transform.Rotate(0, -90, 0);

            if (readyBullet)
            {
                Shoot();
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            targetPlayer = other.gameObject;
            playerFound = true;
            readyBullet = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        targetPlayer = null;
        playerFound = false;
    }

    void Shoot()
    {
        Debug.Log("Shooting");
        muzzleFlash.Play();
        bulletSound.Play();
      Transform _bullet = Instantiate(bullet.transform, bulletSpawn.transform.position,Quaternion.identity );     
       _bullet.transform.rotation =bulletSpawn.transform.rotation;
        readyBullet = false;

        StartCoroutine(fireRate());
        

    }

    IEnumerator fireRate()
    {
        yield return new WaitForSeconds(delayFiring);
        readyBullet = true;
    }
}
