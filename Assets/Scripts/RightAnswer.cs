using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class RightAnswer : MonoBehaviour
{
    public static bool isRight=false;
    public int i=0;
    public void Right()
    {
        isRight = true;
        i = 1;
    }
}
