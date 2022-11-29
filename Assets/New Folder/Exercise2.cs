using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    public int num;

    private void Start ()
    {
        IsEven(num);
    }
    
    
    
    private bool IsEven(int number)
    {
        if (number%2==0)
        {
          Debug.Log($"{number} is even");
            return true;
        }
        else
        {
            Debug.Log($"{number} is NOT even");
            return false;
        }

    }



}
