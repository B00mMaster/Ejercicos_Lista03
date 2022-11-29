using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public int dividend;
    public int divisor;

    private void Start()
    {
        Division(dividend, divisor);
    }


    private void Division(int x, int y)
    {
        if(x%y==0)
        { 
            Debug.Log($"The division of {x}/{y} is exact");
        
        }
        else
        {
            Debug.Log($"The division of {x}/{y} is NOT exact");
        }
    }
}
