using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise9 : MonoBehaviour
{
    public int bAse;

    public int height;


    private void Start()
    {
        Area(bAse, height);
    }


    private void Area(int x, int y)
    {
        if(x > 0 && y > 0)
        {
            Debug.Log($"The area of the triangle is {x*y/2}");
        }
        else
        {
            Debug.Log("The area of the triangle cannot be calculated");
        }
    }













}
