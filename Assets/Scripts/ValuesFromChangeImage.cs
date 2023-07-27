using System;
using TMPro;
using UnityEngine;

public class ValuesFromChangeImage : MonoBehaviour
{
    [SerializeField] TMP_InputField _teamValue;
   public static int _teamValueInt;
    public void GetTeamValue()
    {
        _teamValueInt=Int32.Parse(_teamValue.text);
    }
}
