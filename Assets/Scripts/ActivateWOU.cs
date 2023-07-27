using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class ActivateWOU : MonoBehaviour
{
     ArrayOfQuests array;
    [SerializeField] AudioSource WOU;
    [SerializeField] AudioSource CrazyDiamond;
    [SerializeField] AudioSource D4CLoveTrain;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI reportEvent;
    [SerializeField] GameObject CrazyObject;
    double Change;
    bool CanDoCD=false;
    void Update()
    { 
        array=FindAnyObjectByType<ArrayOfQuests>();
        int UnActiveQuests = 0;
        foreach (var item in array.Quests)
        {
            if (item.activeSelf)
            {
                UnActiveQuests++;
            }
        }

        if(UnActiveQuests == array.Quests.Length)
        {
                int rand = UnityEngine.Random.Range(0, 20000);
            Debug.Log(rand);
                if(rand == 0)
                {
                    WOU.Play();
                double scoreInt = double.Parse(score.text);
                Change = scoreInt;
                scoreInt -= scoreInt * 0.1;
                scoreInt = Math.Round(scoreInt, 0);
                Change -= scoreInt;
                score.text=scoreInt.ToString();
                CanDoCD = true;
                reportEvent.text = "- 10% очков";
                StartCoroutine(Wait1());
                
                    Debug.Log("WonderOfU");

                }
            if (rand == 1)
            {
                D4CLoveTrain.Play();
                double scoreInt = double.Parse(score.text);
                
                scoreInt += scoreInt * 0.1;
                scoreInt = Math.Round(scoreInt, 0);
                score.text = scoreInt.ToString();
                reportEvent.text = "+ 10% очков";
                StartCoroutine(Wait1());

                Debug.Log("D4cLove");
            }

        }
        
    }

    public void DoCrazyDiamond()
    {
        if(CanDoCD)
        {
            CrazyDiamond.Play();
            double scoreInt = double.Parse(score.text);
            scoreInt+=Change;
            
            score.text = scoreInt.ToString();
            CanDoCD = false;

            Debug.Log("CrazyDiamond");
            StartCoroutine(Crazy());
        }
    }

    IEnumerator Crazy()
    {
        yield return new WaitForSeconds(2);
        CrazyObject.SetActive(false);
    }
    IEnumerator Wait1()
    {
        yield return new WaitForSeconds(2);
        
        reportEvent.text = "";
    }
}
