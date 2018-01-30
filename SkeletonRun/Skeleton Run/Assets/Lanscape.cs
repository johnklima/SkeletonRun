using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanscape : MonoBehaviour {
    const int width = 100;
    const int lenght = 100;
    // Generate the mesh with a well-known vertex order
    void Start()
    {
        Mesh mesh = gameObject.AddComponent<MeshFilter>().mesh;
        gameObject.AddComponent<MeshRenderer>();
        mesh.vertices = GenerateVertices(width, lenght);
        mesh.triangles = GenerateTriangles(width, lenght);
        MeshCollider collider = gameObject.AddComponent<MeshCollider>();
        collider.sharedMesh = null;
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
    }
    private void SetVertex(Vector3[] verts, int x, int y, float z)
    {
        verts[width * y + x].z = z;
    }
}
