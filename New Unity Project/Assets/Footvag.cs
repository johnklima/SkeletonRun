using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footvag : MonoBehaviour {
    public Vector3 Vagging;
    private float Uno;
    private float Dos;
    private float Tres;
    private float Quatro;
    private float Zero;
    private bool Up;
    private bool Side;

	// Use this for initialization
	void Start () {
        Up = true;
    }
	
	// Update is called once per frame
	void Update () {

        Uno = transform.position.x;

        if (Dos < 26)
            Up = true;
        if(Up)
            Dos = transform.position.y + 2 * Mathf.Sin(Time.deltaTime * 3);
        else
            Dos = transform.position.y - 2 * Mathf.Sin(Time.deltaTime * 3);
        if (Dos > 44)
            Up = false;
        if (Tres < 20)
            Side = true;
        if (Side)
            Tres = transform.position.z + 2 * Mathf.Sin(Time.deltaTime * 3);
        else
            Tres = transform.position.z - 2 * Mathf.Sin(Time.deltaTime * 3);
        if (Tres > 30)
            Side = false;
        Vagging = new Vector3 (Quatro, Dos, Tres);
        transform.position = Vagging;
	}
}
