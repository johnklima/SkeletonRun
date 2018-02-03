using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour
{

    private Vector3 Value;
    public float Gohan;
    public float Saiyan;
    public bool INeedSleep;
    private GameObject Japan;
    private float Legend;
    [Range(0,10)] 
    private float Alpha;
    public float Beta;
    public GameObject Farlands;


	// Use this for initialization
	void Start () {
        Value = transform.position;
        transform.position = new Vector3(Saiyan, Value.y, Value.z);
    }
    // Update is called once per frame
    void Update() {
        Value = this.transform.position;
        Japan = GameObject.Find("Litterally Japan");
        Farlands = GameObject.Find("Litterally Farlands");
        if (Alpha > 0)
        Alpha = Alpha - 1 * Time.time;
        if (Alpha  < 1)
            Alpha = 0;

        if (INeedSleep)
        {
                    transform.position = new Vector3(Value.x + 2 * Time.deltaTime, Value.y, Value.z);
        }
        else
        {
                    transform.position = new Vector3(Value.x - 2 * Time.deltaTime, Value.y, Value.z);
        }
        if (Vector3.Distance(Japan.transform.position, Value) < Beta)
        {

            INeedSleep = true;
        }
        if (Vector3.Distance(Farlands.transform.position, Value) < Beta)
        {

            INeedSleep = false;
        }

    }

        
}

