using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> protraitData;

    public Sprite[] protraitArr;
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        protraitData = new Dictionary<int, Sprite>();
        GenerateData();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void GenerateData()
    {
        // Talk Data
        // Npc Jang_T : 1000, Npc Kim_T : 2000, Npc Park_T : 3000
        talkData.Add(1000, new string[] { "자 이제 간략하게 설명을 들었으니 이제 선생님들 께서 퀘스트를 줄거야. \n각 교실에서 퀘스트를 달성 후 나에게 오면 입학허가장을 줄게!!:0" });
        talkData.Add(1000 + 100, new string[] { "자 이제 간략하게 설명을 들었으니 이제 선생님들 께서 퀘스트를 줄거야. \n각 교실에서 퀘스트를 달성 후 나에게 오면 입학허가장을 줄게!!:0" });
        talkData.Add(1000 + 200, new string[] { "자 이제 간략하게 설명을 들었으니 이제 선생님들 께서 퀘스트를 줄거야. \n각 교실에서 퀘스트를 달성 후 나에게 오면 입학허가장을 줄게!!:0" });

        talkData.Add(2000, new string[] { "안녕하세요. 수학을 가르치는 김정태 선생님입니다.:0" });
        talkData.Add(2000 + 100, new string[] { "안녕하세요. 수학을 가르치는 김정태 선생님입니다.:0" });
        talkData.Add(2000 + 200, new string[] { "안녕하세요. 수학을 가르치는 김정태 선생님입니다.:0" });

        talkData.Add(3000, new string[] { "안녕하세요. 디자인을 가르치고 있는 박하예린 선생님이에요.:0" });
        talkData.Add(3000 + 100, new string[] { "안녕하세요. 디자인을 가르치고 있는 박하예린 선생님이에요.:0" });
        talkData.Add(3000 + 200, new string[] { "안녕하세요. 디자인을 가르치고 있는 박하예린 선생님이에요.:0" });

        talkData.Add(4000, new string[] { "안녕 나는 발명을 가르치고 있는 신재경 선생님이에요.:0" });
        talkData.Add(4000 + 100, new string[] { "안녕 나는 발명을 가르치고 있는 신재경 선생님이에요.:0" });
        talkData.Add(4000 + 200, new string[] { "안녕 나는 발명을 가르치고 있는 신재경 선생님이에요.:0" });

        talkData.Add(5000, new string[] { "안녕하세요. 선생님도 디자인을 맡은 김효영 선생님입니다.:0" });
        talkData.Add(5000 + 100, new string[] { "안녕하세요. 선생님도 디자인을 맡은 김효영 선생님입니다.:0" });

        talkData.Add(6000, new string[] { "안녕~ 프로그래밍과 게임제작을 가르치는 이희수 선생님이에요.:0" });
        talkData.Add(6000 + 100, new string[] { "안녕~ 프로그래밍과 게임제작을 가르치는 이희수 선생님이에요.:0" });
        talkData.Add(6000 + 200, new string[] { "안녕~ 프로그래밍과 게임제작을 가르치는 이희수 선생님이에요.:0" });

        talkData.Add(7000, new string[] { "안녕하세요. 저는 드론과 프로그래밍을 가르치고 있는 오세운 선생님이에요.:0" });
        talkData.Add(7000 + 200, new string[] { "안녕하세요. 저는 드론과 프로그래밍을 가르치고 있는 오세운 선생님이에요.:0" });

        talkData.Add(8000, new string[] { "안녕~~ 저는 영어를 가르치는 김미리입니다~:0" });
        talkData.Add(8000 + 100, new string[] { "안녕~~ 저는 영어를 가르치는 김미리입니다~:0" });
        talkData.Add(8000 + 200, new string[] { "안녕~~ 저는 영어를 가르치는 김미리입니다~:0" });

        talkData.Add(9000, new string[] { "안녕하세요. 선생님은 프로그래밍과 가상현실 수업을 하고있는 정성일 선생님입니다.:0" });
        talkData.Add(9000 + 100, new string[] { "안녕하세요. 선생님은 프로그래밍과 가상현실 수업을 하고있는 정성일 선생님입니다.:0" });
        talkData.Add(9000 + 200, new string[] { "안녕하세요. 선생님은 프로그래밍과 가상현실 수업을 하고있는 정성일 선생님입니다.:0" });

        talkData.Add(10000, new string[] { "test:0" });
        talkData.Add(10000 + 100, new string[] { "test:0" });
        talkData.Add(10000 + 200, new string[] { "test:0" });

        // obj
        talkData.Add(100, new string[] { "쓰레기가 많이 버려진 쓰레기통이다." });
        
        talkData.Add(200, new string[] { "빈 쓰레기통이다." });

        talkData.Add(300, new string[] { "그냥 필통이다." });

        talkData.Add(400, new string[] { "은지가 버린 양말이다." });



        // Quest Talk
        talkData.Add(10 + 1000, new string[] {"안녕! 우리 과에 온걸 환영합니다. 5층에 방문해줘서 고마워요.:0", "나는 인공지능콘텐츠과 부장 장성국이라고해요. \n" +
            "우리과는 인공지능과 콘텐츠를 결합한 수업을 진행하고 있습니다.:0", "아무래도 컴퓨터와 연관이 되어있겠지?:0", "4차산업에 알맞은 인재들을 키워내고 각각 수업들은 그런 내용이 진행되고 있어 \n" +
            "특별하게 우리과에서는 수학, 영어, 디자인까지 수업을 하고 있고:0", "학습과 실습이 병행된 수업이 진행되고있어! \n그중에 나는 1학년 프로그래밍을 가르치고 있어 !!:0",
            "자 이제 간략하게 설명을 들었으니 이제 선생님들 께서 퀘스트를 줄거야. \n각 교실에서 퀘스트를 달성 후 나에게 오면 입학허가장을 줄게!!:0"});

        talkData.Add(20 + 2000, new string[] { "안녕하세요. 수학을 가르치는 김정태 선생님 입니다.:0", "선생님은 정보처리수학 등 정보와 수학을 결합한 형태의 과목을 가르치고 있어요.\n내가 내는 문제를 풀어보세요.:0"});

        talkData.Add(40 + 2000, new string[] { "정답입니다. 게임1실에 이희수 선생님을 찾아가보세요.:0"});

        talkData.Add(50 + 6000, new string[] { "안녕~ 프로그래밍과 게임제작을 가르치는 이희수 선생님이에요.:0", "여러분이 좋아하는 게임도 수업시간에 제작해서 함께 플레이하는 시간이 있답니다.\n물론 제작만 한다면 재미없겠죠?:0", "선생님이 준비한 게임을 한번 플레이 해볼까요?:0", "탄을 피해서 10초 동안 생존해보세요.\n생존한다면 퀘스트 완료!:0" });

        talkData.Add(70 + 6000, new string[] { "대단하네요! 미션을 성공했어요.\n옆에 있는 교실 게임 2실에서 오세운 선생님을 만나보세요.:0" });

        talkData.Add(80 + 7000, new string[] { "안녕하세요. 저는 드론과 프로그래밍을 가르치고 있는 오세운 선생님이에요.:0", "여러분 드론 날려보셨나요?\n프로그램과 드론을 함께 입력하고 그리고 인공지능과 연계하여 한번 드론을 날려볼게요.:0", "게임 속에 있는 드론이 장애물을 피해 10초동안 자유롭게 날게해봅시다.:0" });

        talkData.Add(100 + 7000, new string[] { "드론이랑 다르지만 간단하게 체험해봤습니다~\n그 다음 장소는 교실입니다. 교실에서 정성일 선생님과 김미리 선생님을 만나보세요.:0" });

        talkData.Add(110 + 8000, new string[] { "안녕~~ 저는 영어를 가르치는 김미리입니다~:0", "4차 산업 시대의 인재들이 되기위해 영어는 필수입니다.\n그렇기 때문에 비즈니스 영어와 같은 수업이 진행되고 있어요.:0", "제가 내는 문제를 한번 풀어볼까요??\n영어를 못해도 괜찮!! 넌센스문제이니 잘생각해보고 풀어보세요.:0" });

        talkData.Add(130 + 8000, new string[] { "영어도 잘하고 센스까지! 고생했어요.\n옆에 있는 정성일 선생님하고 대화해보세요~:0" });

        talkData.Add(140 + 9000, new string[] { "안녕하세요. 선생님은 프로그래밍과 가상현실 수업을 하고있는 정성일 선생님입니다.:0", "프로그래밍을 제작하기 위해선 알고리즘을 알면 편한데요.\n알고리즘은 문제를 해결할때 순서를 나타내는 것입니다.:0", "이 문제에서 빈 칸에 들어갈 알맞은 단어를 찾고 알고리즘을 이해해보도록 합시다.:0" });

        talkData.Add(160 + 9000, new string[] { "잘 했어요~! 간단하지만 그래도 생각해보고 풀수있는 문제였죠.\n자 다음은 응용프로그램실에서 박하예린 선생님을 찾아보세요.:0" });

        talkData.Add(170 + 3000, new string[] { "안녕하세요. 디자인을 가르치고 있는 박하예린 선생님이에요.:0", "디자인 처음에는 어렵겠지만 쉽고 재미있게 여러분과 함께 수업을 진행할 거랍니다.\n선생님이 주는 이 그림을 보고 같은 그림이지만 다른색을 찾아봅시다.:0" });

        talkData.Add(190 + 3000, new string[] { "눈썰미가 대단하네요~\n자 거의 마지막입니다. A.I동상이있는 중앙홀로 가볼까요?:0" });

        talkData.Add(200 + 5000, new string[] { "안녕하세요. 선생님도 디자인을 맡은 선생님입니다.:0", "여러분들이 보고 있는 여러가지 디자인들은 누군가가 만들었겠죠?\n한번 우리도 같이 만들어봅시다.:0", "그중에서 선생님은 여러분에게 같은 그림 찾기를 준비했어요.\n5개의 쌍이 랜덤으로 있는 카드를 짝을 맞춰서 찾아봅시다.:0" });

        talkData.Add(220 + 5000, new string[] { "미션 성공 ! 옆에 계시는 신재경선생님하고 대화를 해보세요~:0" });

        talkData.Add(230 + 4000, new string[] { "안녕 나는 발명을 가르치고 있는 신재경 선생님이에요.:0", "우리 친구가 많은 미션을 성공할줄이야 대단하네요.:0", "우리 학교는 발명학교로 유명한 특성화 고등학교입니다.\n그 안에 인공지능콘텐츠과가 여기구요.:0", "친구가 오늘 실행완료한 미션들은 우리 과에서\n실제로 이뤄지는 교과를 기준으로 재미나게 게임을 만들었어요.:0", "그리고 이 게임을 만든 사람들은 우리 학교 학생들, 즉 선배들이지요.:0", "학교에서 이런 게임을 만드는 모습 재미있지 않나요?\n이런 수업이 이뤄지고 있는 곳입니다~:0", "마지막으로 장성국 선생님이 입학허가증을 줄겁니다.\n처음으로 간 교무실로 가보세요.:0" });

        talkData.Add(240 + 1000, new string[] { "모든 퀘스트를 다하다니 훌륭한 학생이네요!!:0", "재미있었나요?\n우리 학생들이 직접 만들고 기획하고 디자인한 게임을 잘 즐겨주셔서 감사합니다.:0", "자 여기 우리 학과 입학장을 드리겠습니다~:0" });


        // Protrait Data
        // 0: Noraml
        protraitData.Add(1000 + 0, protraitArr[0]);
        protraitData.Add(2000 + 0, protraitArr[1]);
        protraitData.Add(3000 + 0, protraitArr[2]);
        protraitData.Add(4000 + 0, protraitArr[3]);
        protraitData.Add(5000 + 0, protraitArr[4]);
        protraitData.Add(6000 + 0, protraitArr[5]);
        protraitData.Add(7000 + 0, protraitArr[6]);
        protraitData.Add(8000 + 0, protraitArr[7]);
        protraitData.Add(9000 + 0, protraitArr[8]);
        protraitData.Add(10000 + 0, protraitArr[9]);




    }

    public string GetTalk(int id, int talkIndex)
    {
        if(!talkData.ContainsKey(id)) // 해당 퀘스트 진행 순서 중 대사가 없을 때
        {
            if(!talkData.ContainsKey(id - id % 10))
            {
                if(QuestManager.instance.questId < 100)
                {
                    if (talkIndex == talkData[id - id % 100].Length)
                    {
                        return null;
                    }
                    else
                    {

                        return talkData[id - id % 100][talkIndex];
                    }
                }
                else if(QuestManager.instance.questId>= 100 && QuestManager.instance.questId < 200)
                {
                    if (talkIndex == talkData[(id - id % 100) - 100].Length)
                    {
                        return null;
                    }
                    else
                    {

                        return talkData[(id - id % 100) - 100][talkIndex];
                    }
                }
                else if (QuestManager.instance.questId >= 200 && QuestManager.instance.questId < 300)
                {
                    if (talkIndex == talkData[(id - id % 100) - 200].Length)
                    {
                        return null;
                    }
                    else
                    {

                        return talkData[(id - id % 100) - 200][talkIndex];
                    }
                }
                /*
                if (talkIndex == talkData[id - id % 100].Length)
                {
                    return null;
                }
                else
                {
                    
                    return talkData[id - id % 100][talkIndex];        
                }
                */
            }
            else
            {
                // 퀘스트 맨 처음 대사마저 없을 때.
                // 기본 대사를 가지고 온다.
                if (talkIndex == talkData[id - id % 10].Length)
                {
                    return null;
                }
                else
                {
                    return talkData[id - id % 10][talkIndex];
                }
            }
        }
        if(talkIndex == talkData[id].Length)
        {
            return null;
        }
        else
        {
            return talkData[id][talkIndex];
        }
    }

    public Sprite GetPortrait(int id, int protraitIndex)
    {
        return protraitData[id + protraitIndex];
    }
}
