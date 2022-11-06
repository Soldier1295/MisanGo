using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class inputField : MonoBehaviour
{
    public TMP_InputField answerInput;
    public GameObject fail;
    private string answer = null;
    private bool check = false;

    private void Awake()
    {
        answer = answerInput.GetComponent<TMP_InputField>().text;
    }
    void Update()
    {

        if(answer.Length > 0 && Input.GetKeyDown(KeyCode.Return))
        {
            check = true;
            answerCheck();
        }
    }

    public void answerCheck()
    {
        answer = answerInput.text;

        if (answer == "16" && check != true)
        {
            fail.SetActive(false);
            //DataMgr.instance.Game2SceneCheck = true;
            GameManager.instance.MathGameClear = true;
            GameManager.instance.gameCheck();
            SceneManager.LoadScene("TeacherRoom_Scene");
            AudioManager.instance.missionBackgroundAudioStop();
            AudioManager.instance.mainAudioStart();
            

        }
        else
        {
            if(answer != "16")
            {
                fail.SetActive(true);
                check = false;
            }
            
        }
    }
}
