using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QueueShow : MonoBehaviour
{
   public CreateNewTeam newTeamScript;
    [SerializeField] TextMeshProUGUI queueText;

   

    [SerializeField] TextMeshProUGUI points;
    public bool CanShow = true;
    public static int QueueID = 1;
    bool isStart = true;
   
    void Start()
    {      
        ShowQueueAtStart();
    }

    // Update is called once per frame
    void Update()
    {

        if (CanShow)
        {
            int pointInt = Int32.Parse(points.text);
            if (RightAnswer.isRight)
            {
                for (int i = 0; i < newTeamScript.listOfTeams.Count; i++)
                {
                    if (i == QueueShow.QueueID - 1)
                    {
                        GameObject team = newTeamScript.listOfTeams[i];

                        TextMeshProUGUI text = team.GetComponentInChildren<TextMeshProUGUI>();
                        int localScore = Int32.Parse(text.text);
                        localScore += pointInt;
                        text.text = localScore.ToString();
                    }
                }
                RightAnswer.isRight=false;
            }
            Debug.Log("Plus");
            StartCoroutine(QueueWait());
            QueueID++;
            CanShow = false;
            if (QueueID > newTeamScript.listOfTeams.Count)
            {
                QueueID = 1;
            }
        }
    }

    IEnumerator QueueWait()
    {
        if(!isStart)
        yield return new WaitForSeconds(1);
        
        
        queueText.text = "Очередь команды " + QueueID;
        Debug.Log("doing");
        yield return new WaitForSeconds(2);
        queueText.text=null;
    }

    void ShowQueueAtStart()
    {
        CanShow = false;
        StartCoroutine (QueueWait());
        isStart = false;
        
    }
}
