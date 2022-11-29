using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public Vector3 move;


    private void Start()
    {
        Move(move);
    }


    private void Move(Vector3 move)
    {
        transform.position = move;
    }


}
