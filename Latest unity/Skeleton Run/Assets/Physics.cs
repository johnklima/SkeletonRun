using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {

    public Vector3 Ball;
    public float Gravity = -5;
    public Quaternion Roll;
    public float Vegeta = 0;
    public GameObject Goop;
    private float G = -5;
    private float Bolder;
    void Awake()
    {
    }
    void Update()
    {
        Downwards();
    }

    //private void OnCollisionEnter(Collision collision)
    //{
       // Gravity = 0;
       // Debug.Log("It did");
    //}

    //private void OnCollisionExit(Collision collision)
    //{
        //Gravity = -5;
    //}
    void Downwards()
    {
    Ball = this.gameObject.transform.position;
        Roll = this.gameObject.transform.rotation;
        Bolder = Ball.y;
        transform.position = new Vector3(Ball.x, Bolder*Time.deltaTime, Ball.z);
        transform.rotation = Quaternion.Euler (Roll.x, Roll.x, Roll.z * Vegeta * Time.deltaTime);
    }
}
