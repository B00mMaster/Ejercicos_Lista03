using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise8 : MonoBehaviour
{
    public int year;

    private void Start()
    {
        IsLeapYear(year);
    }




    private int IsLeapYear(int theYear)
    {
        if(0==theYear%4)
        {
            if(0==theYear%100)
            {
                if(0==theYear%400)
                {
                    Debug.Log($"{theYear}is a leap year");
                }
                else
                {
                    Debug.Log($"{theYear}is not a leap year");
                }
            }
            else
            {
                Debug.Log($"{theYear}is not a leap year");
            }
        
        
        }
        else
        {
            Debug.Log($"{theYear}is not a leap year");
        }

        return theYear;
     }


























}
