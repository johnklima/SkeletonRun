﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void OnMouseUp()
    {
        SceneManager.LoadScene("RunScreen");
    }
}
