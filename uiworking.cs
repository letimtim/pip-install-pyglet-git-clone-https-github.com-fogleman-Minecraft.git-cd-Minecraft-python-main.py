﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiworking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

	public void startgame(){

        SceneManager.LoadScene(1);
	}
	public void Quit(){

		Application.Quit();
		Debug.Log("Quit is working Perfectly");
	}
}
