using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestManager : MonoBehaviour
{
    public int questId;
    public int questActionIndex;

    Dictionary<int, QuestData> questList;

    public static QuestManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
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

    // Update is called once per frame
    void GenerateData()
    {
        questList.Add(10, new QuestData("[���� ������] �强�� ���������� ����Ʈ �ޱ�", new int[] {1000}));

        questList.Add(20, new QuestData("[���� ������] ������ �����Բ� ����Ʈ �ޱ�", new int[] {2000}));

        questList.Add(30, new QuestData("[���� ������] ������ ������ ����Ʈ Ŭ�����ϱ�", new int[] { 2000 }));

        questList.Add(40, new QuestData("[���� ������] ������ �����԰� ��ȭ�ϱ�", new int[] { 2000 }));

        questList.Add(50, new QuestData("[���� 1��] ����� �����Բ� ����Ʈ �ޱ�", new int[] { 6000 }));

        questList.Add(60, new QuestData("[���� 1��] ����� ������ ����Ʈ Ŭ�����ϱ�", new int[] { 6000 }));

        questList.Add(70, new QuestData("[���� 1��] ����� �����԰� ��ȭ�ϱ�", new int[] { 6000 }));

        questList.Add(80, new QuestData("[���� 2��] ������ �����Բ� ����Ʈ �ޱ�", new int[] { 7000 }));

        questList.Add(90, new QuestData("[���� 2��] ������ ������ ����Ʈ Ŭ�����ϱ�", new int[] { 7000 }));

        questList.Add(100, new QuestData("[���� 2��] ������ �����԰� ��ȭ�ϱ�", new int[] { 7000 }));

        questList.Add(110, new QuestData("[2-5 ����] ��̸� �����Բ� ����Ʈ �ޱ�", new int[] { 8000 }));

        questList.Add(120, new QuestData("[2-5 ����] ��̸� ������ ����Ʈ Ŭ�����ϱ�", new int[] { 8000 }));

        questList.Add(130, new QuestData("[2-5 ����] ��̸� �����԰� ��ȭ�ϱ�", new int[] { 8000 }));

        questList.Add(140, new QuestData("[2-5 ����] ������ �����Բ� ����Ʈ �ޱ�", new int[] { 9000 }));

        questList.Add(150, new QuestData("[2-5 ����] ������ ������ ����Ʈ Ŭ�����ϱ�", new int[] { 9000 }));

        questList.Add(160, new QuestData("[2-5 ����] ������ �����԰� ��ȭ�ϱ�", new int[] { 9000 }));

        questList.Add(170, new QuestData("[���� ���α׷��ֽ�] ���Ͽ��� �����Բ� ����Ʈ �ޱ�", new int[] {3000}));

        questList.Add(180, new QuestData("[���� ���α׷��ֽ�] ���Ͽ��� ������ ����Ʈ Ŭ�����ϱ�", new int[] {3000}));

        questList.Add(190, new QuestData("[���� ���α׷��ֽ�] ���Ͽ��� �����԰� ��ȭ�ϱ�", new int[] { 3000 }));

        questList.Add(200, new QuestData("[�߾�Ȧ] ��ȿ�� �����Բ� ����Ʈ �ޱ�", new int[] { 5000 }));

        questList.Add(210, new QuestData("[�߾�Ȧ] ��ȿ�� ������ ����Ʈ Ŭ�����ϱ�", new int[] { 5000 }));

        questList.Add(220, new QuestData("[�߾�Ȧ] ��ȿ�� �����԰� ��ȭ�ϱ�", new int[] { 5000 }));

        questList.Add(230, new QuestData("[�߾�Ȧ] ����� �����԰� ��ȭ�ϱ�", new int[] { 4000 }));

        questList.Add(240, new QuestData("[���� ������] �强�� �����԰� ��ȭ�ϱ�", new int[] { 1000 }));

        questList.Add(250, new QuestData("����Ʈ ����", new int[] { 0 }));
    }

    public int GetQuestTalkIndex(int id)
    {
        return questId + questActionIndex;
    }

    public string CheckQuest(int id)
    {
        if(id == questList[questId].npcId[questActionIndex])
        {
            questActionIndex++;
        }

        if(questActionIndex == questList[questId].npcId.Length)
        {
            NextQuest();
        }

        return questList[questId].questName;
    }

    public string CheckQuest()
    {
        // Quest Name
        return questList[questId].questName;
    }

    public void NextQuest()
    {
        questId += 10;
        questActionIndex = 0;

        // Kim_T Quest
        if(questId == 30)
        {
            SceneManager.LoadScene("MathGameScene");
            AudioManager.instance.mainAudioStop();
            AudioManager.instance.missionBackgroundAudioStart();
        }
        else if (questId == 60)
        {
            SceneManager.LoadScene("shooting");
            AudioManager.instance.mainAudioStop();
            AudioManager.instance.missionBackgroundAudioStart();
        }
        else if (questId == 90)
        {
            SceneManager.LoadScene("flapScene");
            AudioManager.instance.mainAudioStop();
            AudioManager.instance.missionBackgroundAudioStart();
        }
        else if (questId == 120)
        {
            SceneManager.LoadScene("EnglishGame_Scene");
            AudioManager.instance.mainAudioStop();
            AudioManager.instance.missionBackgroundAudioStart();
        }
        else if (questId == 150)
        {
            SceneManager.LoadScene("Algorithms");
            AudioManager.instance.mainAudioStop();
            AudioManager.instance.missionBackgroundAudioStart();
        }
        // Park_T Quest
        else if (questId == 180)
        {
            SceneManager.LoadScene("FindDFIMG");
            AudioManager.instance.mainAudioStop();
            AudioManager.instance.missionBackgroundAudioStart();
        }
        else if(questId == 210)
        {
            SceneManager.LoadScene("cardgameScene");
            AudioManager.instance.mainAudioStop();
            AudioManager.instance.missionBackgroundAudioStart();
        }
        else if(questId == 250)
        {
            SceneManager.LoadScene("EndCredit");
            AudioManager.instance.mainAudioStop();
            AudioManager.instance.shoutAudioStart();
            
        }
    }
}
