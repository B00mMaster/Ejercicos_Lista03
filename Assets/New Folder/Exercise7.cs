using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    public int number;


    private void Start()
    {
        Absolute(number);
    }



    private int Absolute(int x)
    {
        if (x >= 0)
        {
            Debug.Log($"The absolute value of {x} is {x}");
            return x;

        }
        else
        {
            Debug.Log($"The absolute value of {x} is {x*-1}");
            return x;


        }




    }
}
