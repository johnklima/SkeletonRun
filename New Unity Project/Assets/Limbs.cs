using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limbs : MonoBehaviour
{

    public float Length = 0;
    public bool parental = false;
    public Limbs Parts;
    public Limbs leg = null;
    public Limbs legl = null;
    public Vector3 APos = new Vector3(0, 0, 0);
    public Vector3 BPos = new Vector3(0, 0, 0);

    //----------------------------------------------------

    public void Updatelimb()
    {
        if (parental)
        {
            APos = transform.position;
        }
        else
        {
            APos = leg.BPos;
            transform.position = APos;
        }
        CalculateB();
    }

    //----------------------------------------------------

    public void UpdateAllLimbs()
    {
        Updatelimb();

        if (parental)
            legl.Updatelimb();
    }

    //----------------------------------------------------

    public void CalculateB()
    {
        BPos = APos + transform.forward * Length;
    }

    //----------------------------------------------------

    public void CalculateTarget(Vector3 target)
    {
        transform.LookAt(target);
    }

    //----------------------------------------------------

    public void BringItBack(Vector3 target)
    {
        CalculateTarget(target);
        transform.position = target - transform.forward * Length;
        if (parental) ;
        else
            leg.BringItBack(transform.position);
    }

    //----------------------------------------------------

    public void Reaching(Vector3 target)
    {
        BringItBack(target);
        Updatelimb();
    }

    //----------------------------------------------------

}