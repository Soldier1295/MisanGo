using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public QuestManager questManager;
    public Animator talkPanel;
    public TypeEffect talk;
    public GameObject scanObject;
    public Image portraitImg;
    public Sprite prevPortrait;
    public Animator portraitAnim;
    public bool isAction;
    public int talkIndex;
    public int SceneNumber;

    public bool DfImgGameClear;
    public bool MathGameClear;
    public bool ShootingGameClear;
    public bool EnglishGameClear;
    public bool AlgorithmsGameClear;
    public bool CardGameClear;
    public bool flapGameClear;



    public static GameManager instance;

    private void Awake()
    {
        //SceneNumber = SceneManager.GetActiveScene().buildIndex;
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

    void Start()
    {
        Debug.Log(questManager.CheckQuest());
        QuestPanel.instance.questPanelTalk();

        //talkPanel = GameObjGet.instance.Panel;
        //talkText = GameObjGet.instance.Text;
    }

    public void gameCheck()
    {
        
        if(DfImgGameClear == true)
        {
            AudioManager.instance.questClearAuidoStart();
            questManager.NextQuest();
            Debug.Log(questManager.CheckQuest());
            QuestPanel.instance.questPanelTalk();
        }
        else if(MathGameClear == true)
        {
            AudioManager.instance.questClearAuidoStart();
            questManager.NextQuest();
            Debug.Log(questManager.CheckQuest());
            QuestPanel.instance.questPanelTalk();
        }
        else if (EnglishGameClear == true)
        {
            AudioManager.instance.questClearAuidoStart();
            questManager.NextQuest();
            Debug.Log(questManager.CheckQuest());
            QuestPanel.instance.questPanelTalk();
        }
        else if (AlgorithmsGameClear == true)
        {
            AudioManager.instance.questClearAuidoStart();
            questManager.NextQuest();
            Debug.Log(questManager.CheckQuest());
            QuestPanel.instance.questPanelTalk();
        }
        else if (CardGameClear == true)
        {
            AudioManager.instance.questClearAuidoStart();
            questManager.NextQuest();
            Debug.Log(questManager.CheckQuest());
            QuestPanel.instance.questPanelTalk();
        }
        else if(ShootingGameClear == true)
        {
            AudioManager.instance.questClearAuidoStart();
            questManager.NextQuest();
            Debug.Log(questManager.CheckQuest());
            QuestPanel.instance.questPanelTalk();
        }
        else if (flapGameClear == true)
        {
            AudioManager.instance.questClearAuidoStart();
            questManager.NextQuest();
            Debug.Log(questManager.CheckQuest());
            QuestPanel.instance.questPanelTalk();
        }


    }

    public void Action(GameObject scanObj)
    {
        //Get Current Object
        scanObject = scanObj;
        ObjData objData = scanObject.GetComponent<ObjData>();
        Talk(objData.id, objData.isNpc);

        // Visible Talk for Action
        talkPanel.SetBool("isShow", isAction);
    }

    void Talk(int id, bool isNpc)
    {
        int questTalkIndex = 0;
        string talkData = "";

        // Set Talk Data
        if (talk.isAnim)
        {
            talk.SetMsg("");
            return;
        }
        else
        {
            questTalkIndex = questManager.GetQuestTalkIndex(id);
            talkData = talkManager.GetTalk(id + questTalkIndex, talkIndex);

        }

        // End Talk
        if(talkData == null)
        {
            isAction = false;
            PlayerAction.boolCheck();
            talkIndex = 0;
            Debug.Log(questManager.CheckQuest(id));
            QuestPanel.instance.questPanelTalk();
            return;
        }

        // Continue Talk
        if(isNpc)
        {
            talk.SetMsg(talkData.Split(':')[0]);

            // Show Portrait
            portraitImg.sprite = talkManager.GetPortrait(id, int.Parse(talkData.Split(':')[1]));
            portraitImg.color = new Color(1, 1, 1, 1);
            // Animation Portrait

            /*
            if(prevPortrait != portraitImg.sprite)
            {
                portraitAnim.SetTrigger("doEffect");
                prevPortrait = portraitImg.sprite;
            }
            */
            
        }
        else
        {
            talk.SetMsg(talkData);

            // Hide Portrait
            portraitImg.color = new Color(1, 1, 1, 0);
        }

        isAction = true;
        talkIndex++;
    }

}
