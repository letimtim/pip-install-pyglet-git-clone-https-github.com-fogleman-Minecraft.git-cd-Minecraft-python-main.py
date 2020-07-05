using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    public Text firstInstruction;
    [SerializeField]
    public Image check;
    [SerializeField]
    public float filltime = 2.0f;
    [SerializeField]
    public bool firstComp = false;
    [SerializeField]
    public Text secondInstruction;
    [SerializeField]
    public bool secComp = false;
    [SerializeField]
    public Text thirdInstruction;
    [SerializeField]
    public bool allcomp = false;
    [SerializeField]
    public Image leather;
    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(firstComp == false) {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                firstInstruction.CrossFadeAlpha(0f, 2f, ignoreTimeScale: false);
                check.fillAmount = 100f;
                Invoke("fade1", 2f);
            }
        }
        
        if(secComp == true)
        {
            leather.gameObject.SetActive(true);
            secondInstruction.gameObject.SetActive(true);
            if(Input.GetButtonDown("Fire1")|| Input.GetButtonDown("Fire2"))
            {
                secondInstruction.CrossFadeAlpha(0f, 5f, ignoreTimeScale: false);
                leather.CrossFadeAlpha(0f, 5f, ignoreTimeScale: false);
                Invoke("fadde2", 7f);
            }
        }

        if(allcomp == true)
        {
            thirdInstruction.gameObject.SetActive(true);
            thirdInstruction.CrossFadeAlpha(0f, 15f, ignoreTimeScale: false);
            Invoke("fade3", 20f);
        }
        
    }
    void fade1()
    {
        firstInstruction.gameObject.SetActive(false);
        check.fillAmount = 0f;
        firstComp = true;
        secComp = true;
    }

    void fade2()
    {
        secondInstruction.gameObject.SetActive(false);
        check.fillAmount = 0f;
        secComp = false;
        allcomp = true;
    }

    void fade3()
    {
        thirdInstruction.gameObject.SetActive(false);
        allcomp = false;
    }
   
}
