using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise10 : MonoBehaviour
{



    private void Update()
    {
    if (Input.GetMouseButtonDown(0))
        {
            Scale();
        }
    }









    private void Scale()
    {
        transform.localScale += Vector3.one;
    }
}
