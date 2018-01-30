using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerainGenerationV2 : MonoBehaviour
{

    [Range(0.1f, 20.0f)]
    public float terainrange = 5.0f;
    [Range(0.1f, 20.0f)]
    public float smoothing = 5.0f;

    private Mesh DaMesh;
    private Vector3[] vertices;
    public GameObject cameraposistion;
    public bool boop;
    public Vector3 terainmap;
    public Vector3 stone;
    public float offset = 0;
    public GameObject Grave;
    
    private void Awake()
    {
        {
           // for (int i = 0; i < 10; i++)
            {
             //   Instantiate(this, new Vector3(terainmap.x + 2.0f * i, 0, 0),
               //  transform.rotation = Quaternion.Euler
                // (transform.rotation.x + -90, transform.rotation.y, transform.rotation.z));
            }
        }
    }

    void Update()
    {
        GenerateTerain();
        camerawork();
        LonelyMountain();
    }

    private void LateUpdate()
    {

    }


    void camerawork()
    {
        cameraposistion = GameObject.Find("Scene");
    }
    void GenerateTerain()
    {
        terainmap.x = Mathf.PerlinNoise(transform.position.x, terainrange);
    }
    void LonelyMountain()
    {
        {
            terainmap = this.transform.position;
            if (Vector3.Distance(cameraposistion.transform.position, terainmap) > 20) {
                Instantiate(this, new Vector3(terainmap.x + 32.0f, 0, 0),
                transform.rotation = Quaternion.Euler
                (transform.rotation.x, transform.rotation.y, transform.rotation.z));
                boop = true;
                {
                    //Debug.Log("boop"); //Why does the debug not show? never mind, it did.
                    Object.Destroy(this.gameObject);
                }
            }
        }
    }
}
