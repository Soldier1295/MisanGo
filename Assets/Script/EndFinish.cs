using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFinish : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 15f;

    }

    // Update is called once per frame
    void Update()
    {
        timeCheck();
    }

    public void timeCheck()
    {
        time -= Time.deltaTime;

        if (time < 0)
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
}
