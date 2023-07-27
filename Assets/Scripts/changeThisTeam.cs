using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeThisTeam : MonoBehaviour
{
    public bool Can;
    public static bool ChooseAll;
    private void Update()
    {
        if (Can||ChooseAll)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= transform.right * (0.1f/4);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += transform.right * (0.1f / 4);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.localScale += transform.localScale * (0.1f / 4);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.localScale -= transform.localScale * (0.1f / 4);
            }
        }
    }
    public void CanChange()
    {
        
        if (Can) Can = false;
        else Can = true;
    }
    public void ChooseAl()
    {

        if (ChooseAll) ChooseAll = false;
        else ChooseAll = true;
    }
}
