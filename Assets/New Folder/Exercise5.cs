using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
   //the number to multiply
    public int number;
   
    private int y = 1;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Calculator(number, y);
            y++;
        }
        
    }    

    private void Calculator(int number, int y)
    {
        Debug.Log($"{number}x{y}={number * y}");
    }


}
