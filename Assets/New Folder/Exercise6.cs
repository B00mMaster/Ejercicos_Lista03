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

    private int IsGreater(int num1,int num2)
    {
        if(num1 == num2)
        { Debug.Log("Bouth numbers are equal");
                    return num1;
        }

        else if (num1>num2)
        {
            Debug.Log($"{num1} is larger than {num2}");
                            return num1;

        }

        else
        {
            Debug.Log($"{num2} is larger than {num1}");
                          return num1;

        }











    }















}
