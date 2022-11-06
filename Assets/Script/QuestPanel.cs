using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestPanel : MonoBehaviour
{
    public TextMeshProUGUI questText;
    public QuestManager questManager;
    public static QuestPanel instance;
    public GameObject gameObject2;

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    public void questPanelTalk()
    {
        questText.text = questManager.CheckQuest();
    }
    public void SetActive()
    {
        gameObject2.SetActive(true);
    }
}
