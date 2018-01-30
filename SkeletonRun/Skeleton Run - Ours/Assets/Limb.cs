using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limb : MonoBehaviour {

    public Vector3 AlphaPos = new Vector3(0, 0, 0);
    public Vector3 BetaPos = new Vector3(0, 0, 0);

    public float Lenght = 0;


    public Limb parent = null;
    public Limb child = null;


    public void UpdateSection()
    {
        if (parent)
        {
            AlphaPos = parent.BetaPos;
            transform.position = AlphaPos;
        }
        else
        {
            AlphaPos = transform.position;
        }
        FindBeta();
    }
    public void UpdateSectionsAll()
    {
        UpdateSection();

        if (child)
            child.UpdateSection();
    }
    public void FindBeta()
    {
        BetaPos = AlphaPos + transform.forward * Lenght;
    }

    public void GetTarget(Vector3 target)
    {
        transform.LookAt(target);
    }
    public void ReturnRotation(Vector3 target)
    {
        GetTarget(target);
        transform.position = target - transform.forward * Lenght;
        if (parent)
            parent.ReturnRotation(transform.position);
    }
    public void Reach(Vector3 target)
    {
        ReturnRotation(target);
        UpdateSection();
    }

}

