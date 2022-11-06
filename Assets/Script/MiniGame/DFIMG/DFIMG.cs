using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  DFIMG : MonoBehaviour
{
    public bool input;
    public Vector2 touchPosition;

    public SpriteRenderer check1;
    public SpriteRenderer check2;
    public SpriteRenderer check3;
    public SpriteRenderer check4;

    private bool check_1;
    private bool check_2;
    private bool check_3;
    private bool check_4;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer check1 = gameObject.GetComponent<SpriteRenderer>();
        SpriteRenderer check2 = gameObject.GetComponent<SpriteRenderer>();
        SpriteRenderer check3 = gameObject.GetComponent<SpriteRenderer>();
        SpriteRenderer check4 = gameObject.GetComponent<SpriteRenderer>();
        check_1 = false;
        check_2 = false;
        check_3 = false;
        check_4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            touchPosition = Input.mousePosition;
            input = true;
        }
        if( Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            input = false;
        }

        if (touchPosition.x > 1320 &&  touchPosition.x < 1400 && touchPosition.y > 750 && touchPosition.y < 870)
        {
            StartCoroutine(first());
            //달
        }

        if (touchPosition.x > 1080  &&  touchPosition.x < 1110 && touchPosition.y > 635 && touchPosition.y < 690)
        {
            StartCoroutine(second());
            //커튼
        }

        if (touchPosition.x > 1150  &&  touchPosition.x < 1200 && touchPosition.y > 610 && touchPosition.y < 670)
        {
            StartCoroutine(third());
            //머리띠
        }

        if (touchPosition.x > 1750  &&  touchPosition.x < 1900 && touchPosition.y > 430 && touchPosition.y < 540)
        {
            StartCoroutine(fourth());
            //화분
        }

        if(check_1 == true && check_2 == true && check_3  == true && check_4 == true)
        {
            //씬전환
            DataMgr.instance.FindDfImg = true;
            GameManager.instance.DfImgGameClear = true;
            GameManager.instance.gameCheck();
            SceneManager.LoadScene("ApplicationProgrammingRoom");
            AudioManager.instance.missionBackgroundAudioStop();
            AudioManager.instance.mainAudioStart();
        }



    }

    IEnumerator first()
    {
        for (float i = 0f; i <= 1f; i += 0.1f) {
            
            Color color = new Vector4(1, 1, 1, i); 
            check1.color = color; 
            yield return 0;
        }
        check_1 = true;
        //Debug.Log("1");
    }

    IEnumerator second()
    {
        for (float j = 0f; j <= 1f; j += 0.1f)
        {

            Color color = new Vector4(1, 1, 1, j);
            check2.color = color;
            yield return 0;
            
        }
        check_2 = true;
        //Debug.Log("2");
    }

    IEnumerator third()
    {
        for (float k = 0f; k <= 1f; k += 0.1f)
        {

            Color color = new Vector4(1, 1, 1, k);
            check3.color = color;
            yield return 0;
            
        }
        check_3 = true;
        //Debug.Log("3");
    }

    IEnumerator fourth()
    {
        for (float f = 0f; f <= 1f; f += 0.1f)
        {

            Color color = new Vector4(1, 1, 1, f);
            check4.color = color;
            yield return 0;
            
        }
        check_4 = true;
        //Debug.Log("4");
    }
}
