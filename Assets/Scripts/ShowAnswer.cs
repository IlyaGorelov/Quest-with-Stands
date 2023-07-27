using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowAnswer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _answer;
    [SerializeField] string _answerText;
    [SerializeField] GameObject ImageOfAnswer;
    [SerializeField] GameObject Quest;
    public QueueShow queueShow;
    public void ShowAnswerThenClose()
    {
        queueShow.CanShow = true;
        StartCoroutine(CloseImage());
        
    }

    public void OnlyShow()
    {
        _answer.text = _answerText;

    }
    IEnumerator CloseImage()
    {
        yield return new WaitForSeconds(1);
        ImageOfAnswer.SetActive(false);
        Quest.SetActive(false);
        yield return new WaitForSeconds(1);
    }
    
}
