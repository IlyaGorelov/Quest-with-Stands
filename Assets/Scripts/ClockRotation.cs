using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class ClockRotation : MonoBehaviour
{
    public GameObject _arrow;
    [SerializeField] int time = 30;

    public VideoPlayer[] _player;
    public TextMeshProUGUI timeText;
    public Animation _tempTextAnim;
    public TextMeshProUGUI _tempText;
   
    public AudioSource[] clockTicking;
    public AudioSource kingCrimsonSound;
    int randomValue ;
    // Update is called once per frame
    bool IsStart = false;
    IEnumerator cor;
    private void Start()
    {
        cor = Rotatr();
         randomValue = Random.Range(0, 3);
    }

    public void StartTime()
    {
        if (!IsStart)
        {
            IsStart = true;

            StartCoroutine(cor);
        }
        else
        {
            IsStart = false;
            
            StopCoroutine(cor);
        }
    }
    IEnumerator Rotatr()
    {
       int RandomMelody = Random.Range(0, clockTicking.Length);
        if (randomValue == 0)
        {
                clockTicking[RandomMelody].Play();
            while (time >= 0 || !IsStart)
            {
                _arrow.transform.localRotation *= Quaternion.Euler(0, 0, -12);
                yield return new WaitForSeconds(1);
                timeText.text = time.ToString();
                time--;
                if (time == 9)
                {
                    clockTicking[RandomMelody].Pause();
                    _tempText.text = "+ 10 секунд";
                    _tempTextAnim.Play();
                    _player[0].Play();
                    yield return new WaitForSeconds(15);
                    clockTicking[RandomMelody].Play();
                    _arrow.transform.localRotation *= Quaternion.Euler(0, 0, -12);
                }
            }
            clockTicking[RandomMelody].Stop();
        }
        if (randomValue == 1)
        {
                clockTicking[RandomMelody].Play();
            while (time >= 0 || !IsStart)
            {
                _arrow.transform.localRotation *= Quaternion.Euler(0, 0, -12);
                yield return new WaitForSeconds(1);
                timeText.text = time.ToString();
                time--;
                if (time == 9)
                {
                    kingCrimsonSound.Play();
                        
                    clockTicking[RandomMelody].Pause();
                    yield return new WaitForSeconds(1);
                    _tempText.text = "- 10 секунд";
                    _tempTextAnim.Play();
                    _player[randomValue].Play();
                    time -= 9;              
                    _arrow.transform.localRotation = Quaternion.identity;
                }
            }
            clockTicking[RandomMelody].Stop();
        }
        if (randomValue == 2)
        {
                clockTicking[RandomMelody].Play();
            while (time >= 0 || !IsStart)
            {
                _arrow.transform.localRotation *= Quaternion.Euler(0, 0, -12);
                yield return new WaitForSeconds(1);
                timeText.text = time.ToString();
                time--;
                
            }
            clockTicking[RandomMelody].Stop();
        }
    }

}
