using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerainGenerationBox : MonoBehaviour
{
    private Mesh DaMesh;
    private Vector3[] vertices;
    public GameObject cameraposistion;
    public bool boop;
    public Vector3 terainmap;
    public Vector3 stone;
    public float offset = 0;
    public GameObject Grave;
    private Mesh DaRef;
    private Vector3 FinalPos;
    private float posistion;
    public Vector3 cobe;
    private Vector3 jobe;
    private Vector3 aobe;
    private Vector3 bobe;
    private Vector3 dobe;
    private Vector3 eobe;
    private Vector3 fobe;
    private Vector3 gobe;
    private Vector3 hobe;
    private Vector3 iobe;
    private Vector3 kobe;
    private Vector3 lobe;

    private void Awake()
    {

    }

    void Update()
    {
        GenerateTerain();
        camerawork();
        //Gravestones();
        //LonelyMountain();
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
        {
            GameObject[] gos;
            gos = GameObject.FindGameObjectsWithTag("Respawn");
            GameObject closest = null;
            float distance = Mathf.Infinity;
            Vector3 position = transform.position;
            foreach (GameObject go in gos)
            {
                Vector3 diff = go.transform.position - position;
                float curDistance = diff.sqrMagnitude;
                if (curDistance < distance)
                {
                    closest = go;
                    distance = curDistance;
                }
            }
            aobe = closest.GetComponent<TerainGeneration>().aobe;
            bobe = closest.GetComponent<TerainGeneration>().bobe;
            cobe = closest.GetComponent<TerainGeneration>().cobe;
            dobe = closest.GetComponent<TerainGeneration>().dobe;
            eobe = closest.GetComponent<TerainGeneration>().eobe;
            fobe = closest.GetComponent<TerainGeneration>().fobe;
            gobe = closest.GetComponent<TerainGeneration>().gobe;
            hobe = closest.GetComponent<TerainGeneration>().hobe;
            iobe = closest.GetComponent<TerainGeneration>().iobe;
            jobe = closest.GetComponent<TerainGeneration>().jobe;
            kobe = closest.GetComponent<TerainGeneration>().kobe;
            lobe = closest.GetComponent<TerainGeneration>().lobe;
        }


        //DaRef.vertices = theOtherVertices;
        vertices = DaMesh.vertices;
        {
            vertices[1] = aobe;
            vertices[2] = bobe;
            vertices[3]  = cobe;
            vertices[4]  = dobe;
            vertices[5]  = eobe;
            vertices[6]  = fobe;
            vertices[7]  = gobe;
            vertices[8]  = hobe;
            vertices[9]  = iobe;
            vertices[10]  = jobe;
            vertices[11] = kobe;
            vertices[12] = lobe;


            {
                DaMesh.vertices = vertices;
                DaMesh.RecalculateBounds();
                DaMesh.RecalculateNormals();
                {

                    Destroy(gameObject.GetComponent<MeshCollider>());
                    MeshCollider collider = gameObject.AddComponent<MeshCollider>();
                    collider.sharedMesh = null;
                    collider.sharedMesh = DaMesh;
                    //collider.convex = true; //Not needeed.
                }
            }
        }
        
    }


            //stone.x = (vertices[i].x + transform.position.x) / smoothing * terainrange + offset;
            //stone.y = (vertices[i].y + transform.position.y) / smoothing * terainrange + offset;
        
    //void Gravestones()
  //  {
      //  Grave = GameObject.Find("Grave");
      //  stone.z = Mathf.PerlinNoise(
      //  (stone.x + transform.position.x) / smoothing,
      //  (stone.y + transform.position.y) / smoothing)
     //   * terainrange;
     //   {
     //       Instantiate(Grave, new Vector3(stone.x, stone.y, stone.z),
     //       transform.rotation = Quaternion.Euler
      //      (transform.rotation.x + -90, transform.rotation.y, transform.rotation.z));
     //   }

  //  }
    //void LonelyMountain()
    //{
       // {
          //  terainmap = this.transform.position;
          //  if (Vector3.Distance(cameraposistion.transform.position, terainmap) > 25) {
          //      Instantiate(this, new Vector3(terainmap.x + 40.0f, 0, 0),
          //      transform.rotation = Quaternion.Euler
          //      (transform.rotation.x, transform.rotation.y, transform.rotation.z));
          //      boop = true;
          //      {
                    //Debug.Log("boop"); //Why does the debug not show? never mind, it did.
          //          Object.Destroy(this.gameObject);
          //      }
         //   }
       // }
  //  }
}
