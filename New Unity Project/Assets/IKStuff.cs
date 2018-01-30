using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKStuff : MonoBehaviour
{
    public Transform target = null;
    public Vector3 APos = new Vector3(0, 0, 0);
    public float Length = 0;
    public Limbs Parts;
    public Limbs leg;
    public Limbs legl;

    public void Reach()
    {
        legl.BringItBack(target.position);

        leg.transform.position = transform.position;
        leg.UpdateAllLimbs();
    }
}