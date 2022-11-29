using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{
    public int number1;
    public int number2;

    private void Start()
    {
        IsGreater(number1, number2);
    }

    // which of them is greater
    private int IsGreater(int x,int y)
    {
        if(x == y)
        { Debug.Log("Bouth numbers are equal");
                    return x;
        }

        else if (x>y)
        {
            Debug.Log($"{x} is greater than {y}");
                            return x;

        }

        else
        {
            Debug.Log($"{y} is greater than {x}");
                          return x;

        }











    }















}
