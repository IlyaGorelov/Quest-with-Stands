using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MadeInHeaven : MonoBehaviour
{
    [SerializeField] AudioSource _madeInHeaven;
    
    
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
        if (Input.GetKey(KeyCode.LeftShift)&&Input.GetKeyDown(KeyCode.F1))
        {

            if (canDo1)
            {
                _madeInHeaven.Play();

                canDo1 = false;
                StartCoroutine(Acceleration());
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F2))
        {

            if (canDo2)
            {
                _madeInHeaven.Play();

                canDo2 = false;
                StartCoroutine(Acceleration());
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F3))
        {

            if (canDo3)
            {
                _madeInHeaven.Play();

                canDo3 = false;
                StartCoroutine(Acceleration());
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F4))
        {

            if (canDo4)
            {
                _madeInHeaven.Play();

                canDo4 = false;
                StartCoroutine(Acceleration());
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F5))
        {

            if (canDo5)
            {
                _madeInHeaven.Play();

                canDo5 = false;
                StartCoroutine(Acceleration());
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F6))
        {

            if (canDo6)
            {
                _madeInHeaven.Play();

                canDo6 = false;
                StartCoroutine(Acceleration());
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F7))
        {

            if (canDo7)
            {
                _madeInHeaven.Play();

                canDo7 = false;
                StartCoroutine(Acceleration());
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F8))
        {

            if (canDo8)
            {
                _madeInHeaven.Play();

                canDo8 = false;
                StartCoroutine(Acceleration());
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F9))
        {

            if (canDo9)
            {
                _madeInHeaven.Play();

                canDo9 = false;
                StartCoroutine(Acceleration());
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F10))
        {

            if (canDo10)
            {
                _madeInHeaven.Play();

                canDo10 = false;
                StartCoroutine(Acceleration());
            }
        }
        
    }  

    IEnumerator Acceleration()
    {
        yield return new WaitForSeconds(2);
        Time.timeScale = 3f;
        yield return new WaitForSecondsRealtime(10);
        Time.timeScale = 1;
    }
}
