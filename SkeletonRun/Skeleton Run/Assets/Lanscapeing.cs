using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanscapeing : MonoBehaviour {
    private Mesh DaMesh;
    private Vector3[] vertices;
    public GameObject cameraposistion;
    public bool boop;
    public Vector3 terainmap;
    public Vector3 stone;
    public float offset = 0;
    public GameObject Grave;
    private Mesh Radagast;
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

    const int width = 11;
    const int lenght = 11;
    // Generate the mesh with a well-known vertex order
    void Start()
    {
        Mesh mesh = gameObject.AddComponent<MeshFilter>().mesh;
        gameObject.AddComponent<MeshRenderer>();
        mesh.vertices = GenerateVertices(width, lenght);
        mesh.triangles = GenerateTriangles(width, lenght);
        Mesh Vollider = gameObject.AddComponent<MeshCollider>().sharedMesh;
        Vollider.vertices = GenerateVertices(width, lenght);
        Vollider.triangles = GenerateTriangles(width, lenght);
    }

    private int[] GenerateTriangles(int width, int lenght)
    {
        //generate two triangles per vertex except the last column and last row
        int[] triangles = new int[(width - 1) * (lenght - 1) * 6];
        for (int y = 0; y < lenght - 1; y++)
        {
            for (int x = 0; x < width - 1; x++)
            {
                triangles[(y * (width - 1) + x) * 6] = y * width + x;
                triangles[(y * (width - 1) + x) * 6 + 1] = y * width + x + 1;
                triangles[(y * (width - 1) + x) * 6 + 2] = y * width + x + 1 + width;
                triangles[(y * (width - 1) + x) * 6 + 3] = y * width + x;
                triangles[(y * (width - 1) + x) * 6 + 4] = y * width + x + 1 + width;
                triangles[(y * (width - 1) + x) * 6 + 5] = y * width + x + width;
            }
        }
        return triangles;
    }

    Vector3[] GenerateVertices(int width, int height)
    {
        Vector3[] vertices = new Vector3[width * height];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                vertices[y * width + x] = new Vector3(x / (float)width, y / (float)height);
            }
        }
        return vertices;
    }

    void Update()
    {
        Mesh mesh = this.gameObject.GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        //SetVertex(vertices, 0,0,0);
        mesh.vertices = vertices;
        GenerateTerain();
        camerawork();
    }
    private void LateUpdate()
    {
        Mesh Vollider = gameObject.GetComponent<MeshCollider>().sharedMesh;
        Vollider.vertices = vertices;
    }
    private void SetVertex(Vector3[] verts, int x, int y, float z)
    {
        verts[width * y + x].z = z;
    }
    void Size()
    {

    }
    void camerawork()
    {
        cameraposistion = GameObject.Find("Main Camera");
    }

    void GenerateTerain()
    {
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
        {
            vertices[1] = aobe;
            vertices[2] = bobe;
            vertices[3] = cobe;
            vertices[4] = dobe;
            vertices[5] = eobe;
            vertices[6] = fobe;
            vertices[7] = gobe;
            vertices[8] = hobe;
            vertices[9] = iobe;
            vertices[10] = jobe;
            vertices[11] = kobe;
            vertices[12] = lobe;
            
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
