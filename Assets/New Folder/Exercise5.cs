using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
   //number to multiply
    public int number;

    private int z = 1;


    private void Start()
    {
        Calculator(number, z);
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Calculator(number, z);
            z++;
        }
    }
    private void Calculator(int x, int y)
    {
        Debug.Log($"{x}x{y}={x * y}");
    }








}
