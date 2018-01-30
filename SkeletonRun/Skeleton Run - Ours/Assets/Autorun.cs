using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autorun : MonoBehaviour {


    //private object cameraobject = ;
    //float Cameraspeed = cameraobject.transform.position.forward;
    public Vector3 Cameraspeed;
    public float Goku = 5.0f;

    void Awake()
    {

    }

    void Update()
    {
        Camerarun();
    }
    void Camerarun()
    {
        Cameraspeed = this.transform.position;
        transform.position = new Vector3(Cameraspeed.x + Goku * Time.deltaTime, Cameraspeed.y, Cameraspeed.z);

    }

}
