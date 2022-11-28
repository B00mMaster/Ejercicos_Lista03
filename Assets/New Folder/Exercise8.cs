using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise8 : MonoBehaviour
{
    public int year;

    private void Start()
    {
        LeapYear(year);
    }




    private int LeapYear(int year)
    {
        if(0==year%4)
        {
            if(0==year%100)
            {
                if(0==year%400)
                {
                    Debug.Log($"{year}is a leap year");
                }
                else
                {
                    Debug.Log($"{year}is not a leap year");
                }
            }
            else
            {
                Debug.Log($"{year}is not a leap year");
            }
        
        
        }
        else
        {
            Debug.Log($"{year}is not a leap year");
        }

        return year;
     }


























}
