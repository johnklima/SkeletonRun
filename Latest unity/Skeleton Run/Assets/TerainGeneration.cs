using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerainGeneration : MonoBehaviour
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
    public Vector3 jobe;
    public Vector3 aobe;
    public Vector3 bobe;
    public Vector3 cobe;
    public Vector3 dobe;
    public Vector3 eobe;
    public Vector3 fobe;
    public Vector3 gobe;
    public Vector3 hobe;
    public Vector3 iobe;
    public Vector3 kobe;
    public Vector3 lobe;
    
    private void Awake()
    {

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
        cameraposistion = GameObject.Find("Main Camera");
    }

    void GenerateTerain()
    {
        DaMesh = this.GetComponent<MeshFilter>().mesh;
        vertices = DaMesh.vertices;

        int isthisup = 0;//i?
        int isthissideways = 0;//j?

        for (int i = 0; i < 11; i++) {
            for (int j = 0; j < 11; j++) {
                Madness(isthisup, isthissideways);//vertice calculating
                isthisup++;
            }
            isthissideways++;
        }
        DaMesh.vertices = vertices;
        DaMesh.RecalculateBounds();
        DaMesh.RecalculateNormals();

        Destroy(gameObject.GetComponent<MeshCollider>());
        MeshCollider collider = gameObject.AddComponent<MeshCollider>();
        collider.sharedMesh = null;
        collider.sharedMesh = DaMesh;
        //collider.convex = true; //Not needeed.
    }

    void Madness(int i, int j) { //remember
        vertices[i].z = Mathf.PerlinNoise(
            (vertices[i].x + transform.position.x) / smoothing,
            (vertices[i].y + transform.position.y) / smoothing)
            * terainrange;
        vertices[i].z -= j;
        {
            
            aobe = vertices[1];
            bobe = vertices[2];
            cobe = vertices[3];
            dobe = vertices[4];
            eobe = vertices[5];
            fobe = vertices[6];
            gobe = vertices[7];
            hobe = vertices[8];
            iobe = vertices[9];
            jobe = vertices[10];
            kobe = vertices[11];
            lobe = vertices[12];

        }
    }
    void LonelyMountain()
    {
        {
            terainmap = this.transform.position;
            if (Vector3.Distance(cameraposistion.transform.position, terainmap) > 25) {
                Instantiate(this, new Vector3(terainmap.x + 40.0f, 0, terainmap.z),
                transform.rotation = Quaternion.Euler
                (transform.rotation.x + -90, transform.rotation.y, transform.rotation.z));
                boop = true;
                {
                    //Debug.Log("boop"); //Why does the debug not show? never mind, it did.
                    Object.Destroy(this.gameObject);
                }
            }
        }
    }
}
