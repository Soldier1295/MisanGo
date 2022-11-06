using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerCheck : MonoBehaviour
{
    public GameObject fail;
    public void ButtonClick()
    {
        if (QuizCheckBox.checkBox == true && QuizCheckBox2.checkBox == true && QuizCheckBox3.checkBox == true)
        {
            
            if(AnswerManager.instance.Quiz1 == true && AnswerManager.instance.Quiz2 == true && AnswerManager.instance.Quiz3 == true)
            {
                DataMgr.instance.EnglishGame = true;
                fail.SetActive(false);
                Debug.Log("clear");
                GameManager.instance.EnglishGameClear = true;
                GameManager.instance.gameCheck();
                SceneManager.LoadScene("ClassRoom_Scene");
                AudioManager.instance.missionBackgroundAudioStop();
                AudioManager.instance.mainAudioStart();
            }
            else
            {
                Debug.Log("fail");
                fail.SetActive(true);
            }
            
        }
        else
        {
            Debug.Log("모든 항목을 체크해주세요");
        }
    }

    public void AlButtonClick()
    {
        if (QuizCheckBox.checkBox2 == true)
        {

            if (Algorithms.instance.Quiz == true)
            {
                DataMgr.instance.AlgorithmsGame = true;
                fail.SetActive(false);
                Debug.Log("clear");
                GameManager.instance.EnglishGameClear = true;
                GameManager.instance.gameCheck();
                SceneManager.LoadScene("ClassRoom_Scene");
                AudioManager.instance.missionBackgroundAudioStop();
                AudioManager.instance.mainAudioStart();
            }
            else
            {
                Debug.Log("fail");
                fail.SetActive(true);
            }

        }
        else
        {
            Debug.Log("모든 항목을 체크해주세요");
        }
    }
}
