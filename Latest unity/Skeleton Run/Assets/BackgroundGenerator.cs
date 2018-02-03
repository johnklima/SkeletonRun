using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour
{

    float Bselect;
    public Vector3 pos;
    public GameObject back1;
    public GameObject back2;
    public GameObject back3;
    public GameObject back4;
    public GameObject back5;
    public GameObject cameraposistion;

    void Awake()
    {
        Bselect = Random.Range(1, 5);
        back1 = GameObject.Find("Background 1");
        back2 = GameObject.Find("Background 2");
        back3 = GameObject.Find("Background 3");
        back4 = GameObject.Find("Background 4");
        back5 = GameObject.Find("Background 5");
        Camerawork();
        Mackground();
    }

    void Update()
    {
        Bselect = Random.Range(1, 5);
        Mackground();
        Camerawork();
        Nuttshell();
    }
    void Camerawork()
    {
        cameraposistion = GameObject.Find("Main Camera");
    }
    void Nuttshell()
    {
        pos = this.transform.position;
    }
    void Mackground()
    {
        if (Vector3.Distance(cameraposistion.transform.position, pos) > 30)
        {
            if (Bselect.Equals(1))
            {
                Instantiate(back1, new Vector3(pos.x + 40.0f, 5.0f, 10.0f),
                transform.rotation = Quaternion.Euler
                (transform.rotation.x + 90, transform.rotation.y, transform.rotation.z));
                Object.Destroy(this.gameObject);
            }
            if (Bselect.Equals(2))
            {
                Instantiate(back2, new Vector3(pos.x + 40.0f, 5.0f, 10.0f),
                transform.rotation = Quaternion.Euler
                (transform.rotation.x + 90, transform.rotation.y, transform.rotation.z));
                Object.Destroy(this.gameObject);
            }
            if (Bselect.Equals(3))
            {
                Instantiate(back3, new Vector3(pos.x + 40.0f, 5.0f, 10.0f),
                transform.rotation = Quaternion.Euler
                (transform.rotation.x + 90, transform.rotation.y, transform.rotation.z));
                Object.Destroy(this.gameObject);
            }
            if (Bselect.Equals(4))
            {
                Instantiate(back4, new Vector3(pos.x + 40.0f, 5.0f, 10.0f),
                transform.rotation = Quaternion.Euler
                (transform.rotation.x + 90, transform.rotation.y, transform.rotation.z));
                Object.Destroy(this.gameObject);
            }
            if (Bselect.Equals(5))
            {
                Instantiate(back5, new Vector3(pos.x + 40.0f, 5.0f, 10.0f),
                transform.rotation = Quaternion.Euler
                (transform.rotation.x + 90, transform.rotation.y, transform.rotation.z));
                Object.Destroy(this.gameObject);
            }
        }
    }
}
