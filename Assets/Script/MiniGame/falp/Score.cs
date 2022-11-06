using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore = 0;
    public static int deathcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString();
        clear();


    }

    void clear()
    {
        if(score >= 5)
        {
            //Debug.Log("clear");
            DataMgr.instance.flappyBird = true;
            GameManager.instance.flapGameClear = true;
            GameManager.instance.gameCheck();
            SceneManager.LoadScene("Game2_Scene");
            AudioManager.instance.missionBackgroundAudioStop();
            AudioManager.instance.mainAudioStart();
        }
    }
}
