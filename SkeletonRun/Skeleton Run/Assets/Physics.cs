using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {

    public Vector3 Ball;
    public float Gravity = -5;
    public Quaternion Roll;
    public float Vegeta = 5;
    public GameObject Goop;
    private float G = -5;

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
        transform.position = new Vector3(Ball.x, Ball.y + Gravity * Time.deltaTime, Ball.z);
        transform.rotation = Quaternion.Euler (Roll.x, Roll.y, Roll.z * Vegeta * Time.deltaTime);
    }
}
