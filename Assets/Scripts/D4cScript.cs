using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class D4cScript : MonoBehaviour
{
    [SerializeField] AudioSource D4C;
    [SerializeField] TextMeshProUGUI questOld;
    [SerializeField] string QuestNew;
    static bool canDo1 = true;
     static bool canDo2 = true;
         static bool canDo3 = true;
     static bool canDo4 = true;
     static bool canDo5 = true;
    static bool canDo6 = true;
        static bool canDo7 = true;
    static bool canDo8 = true;
    static bool canDo9 = true;
    static bool canDo10 = true;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            
            if (canDo1)
            {
                D4C.Play();
                questOld.text = QuestNew;
                 canDo1 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
           
            if (canDo2)
            {
                D4C.Play();
                questOld.text = QuestNew;
                canDo2 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            
            if (canDo3)
            {
                D4C.Play();
                questOld.text = QuestNew;
                canDo3 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
           
            if (canDo4)
            {
                D4C.Play();
                questOld.text = QuestNew;
                canDo4 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
           
            if (canDo5)
            {
                D4C.Play();
                questOld.text = QuestNew;
                canDo5 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
           
            if (canDo6)
            {
                D4C.Play();
                questOld.text = QuestNew;
                canDo6 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.F7))
        {
           
            if (canDo7)
            {
                D4C.Play();
                questOld.text = QuestNew;
                canDo7 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.F8))
        {
            
            if (canDo8)
            {
                D4C.Play();
                questOld.text = QuestNew;
                canDo8 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.F9))
        {
           
            if (canDo9)
            {
                D4C.Play();
                questOld.text = QuestNew;
                canDo9 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.F10))
        {
          
            if (canDo10)
            {
                D4C.Play();
                questOld.text = QuestNew;
                canDo10 = false;
            }
        }
    }
}
