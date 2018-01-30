using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IK : MonoBehaviour {

    private int Pieces;
    public Limb[] Limbs;

    public Transform target = null;

    public Limb FirstLimb;
    public Limb LastLimb;
    public bool Active = true;

    private void Awake()
    {
        Pieces = transform.childCount;
        Limbs = new Limb[Pieces];
        int i = 0;
        foreach (Transform Child in transform)
        {
            Limbs[i] = Child.GetComponent<Limb>();
            i++;
        }

        FirstLimb = Limbs[0];
        LastLimb = Limbs[Pieces - 1];
    }

    void Update()
    {
        if (Active)
            Reacher();
    }

    public void Reacher()
    {
        LastLimb.Reach(target.position);

        FirstLimb.transform.position = transform.position;
        FirstLimb.UpdateSectionsAll();
    }



}
