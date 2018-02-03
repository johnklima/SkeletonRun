using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robber : MonoBehaviour {

    public GameObject Grave;
	// Use this for initialization
	void Start () {
        Grave = GameObject.Find("Grave");
        Instantiate(Grave, new Vector3(this.transform.position.x, 12, 0),
transform.rotation = Quaternion.Euler
(transform.rotation.x, transform.rotation.y, transform.rotation.z));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
