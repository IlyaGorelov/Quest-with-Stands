using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingOnButtons : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F5)) 
        {
            SaveLoad.Save();
        }
        if (Input.GetKeyDown(KeyCode.F9))
        {
            SaveLoad.Load();
        }
    }
}
