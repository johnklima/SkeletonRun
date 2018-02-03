using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsies : MonoBehaviour {

    public float Gohan = 0;
    private Vector3 Post;

    void Update()
    {
        Post = new Vector3(transform.position.z + (2*Time.deltaTime*Gohan), transform.position.y, transform.position.z);
        transform.position = Post;
    }
    private void LateUpdate()
    {
        transform.position = Post;
    }
}
