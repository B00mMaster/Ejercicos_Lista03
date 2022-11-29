using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{

    public string l;


    private void Start()
    {
        IsVowel(l);

    }



    private bool IsVowel(string letter)
    {

        if (letter is "a" or "e" or "i" or "o" or "u")
        {
            Debug.Log($"{letter} is vowel");
            return true;
        }
        else
        {
            Debug.Log($"{letter} is consonant");
            return false;
        }

    }
}
