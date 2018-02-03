using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour {
    private Quaternion Roll;
    public float Rock; //Does they float on lava though? JK XD

    // Use this for initialization
    void Start() {
        Roll = transform.rotation;
        Roll.y = 180;
        //transform.position = new Vector3(4.0f, 9.0f, 16.0f);
    }

    // Update is called once per frame
    void Update() {
        controlls();
    }
    void controlls()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Roll.x = Roll.x * Rock;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Roll.y = Roll.y * Rock;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Roll.x = Roll.z * Rock;
        }

        this.transform.rotation = Quaternion.Euler(Roll.x, Roll.y, Roll.z);


    }

}