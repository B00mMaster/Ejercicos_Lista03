using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public Vector3 move= new Vector3(0,0,0);

    private void Start()
    {
        transform.position=move;
    }


}
