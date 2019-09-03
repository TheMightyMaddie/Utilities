using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    public static string ProcessText(string textIn)
    {
        //return textIn;
        string resultA = "Is number";
        string resultB = "Is string";
        float number;
        if (float.TryParse(textIn, out number))
            return resultA;
        else
            return resultB;

        //return the word 'string' if the user enters a string
        //return the word 'number' if the user enters a number (including 1.2 decimalish numbers called doubles, floats
    }
}