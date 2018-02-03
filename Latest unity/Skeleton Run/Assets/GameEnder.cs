using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnder : MonoBehaviour {
    private Collider Head;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     
		
	}
    private void OnTriggerEnter(Collider Respawn)
    {
        SceneManager.LoadScene("EndScreen");
    }
}
