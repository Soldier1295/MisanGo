using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public GameObject gameObject;

    public void ButtonClick()
    {
        if(CheckBox.checkBox == true)
        {
            SceneManager.LoadScene("PlayScene");
            

        }
        else
        {
            Debug.Log("성별을 체크해주세요.");
        }
    }

    public void StartButtonClick()
    {
        SceneManager.LoadScene("SelectScene");
    }

    public void creditButtonClick()
    {
        gameObject.SetActive(true);
    }

    public void creditCloseButtonClick()
    {
        gameObject.SetActive(false);
    }

    public void ExitButtonClick()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
        #else
         Application.Quit();
        #endif

    }
   
}
