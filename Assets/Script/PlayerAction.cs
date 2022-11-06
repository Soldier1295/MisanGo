using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAction : MonoBehaviour
{
    public float Speed;
    //public TalkManager manager;

    Rigidbody2D rb2d;
    Animator anim;
    Vector3 dirVec;
    static GameObject scanObject;
    float h;
    float v;
    bool isHorizonMove;
    public int SceneNumber;
    bool check = false;
    static int up_Value;
    static int down_Value;
    static int left_Value;
    static int right_Value;
    static bool up_down;
    static bool down_down;
    static bool left_down;
    static bool right_down;
    static bool up_up;
    static bool down_up;
    static bool left_up;
    static bool right_up;
    static bool touchCheck;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        SceneNumber = SceneManager.GetActiveScene().buildIndex;
        if (SceneNumber == 9)
        {
            DataMgr.instance.AppSceneCheck = true;
        }
        else if(SceneNumber == 15)
        {
            DataMgr.instance.Game2SceneCheck = true;
        }
        else if (SceneNumber == 17)
        {
            DataMgr.instance.ClassRoomCheck = true;
        }
        else if(SceneNumber != 0 && check == false)
        {
            QuestPanel.instance.SetActive();
            check = true;
        }

        if(SceneNumber == 2 && AudioManager.instance.check == false)
        {
            AudioManager.instance.check = true;
            MainAudio.instance.MusicDestroy();
            AudioManager.instance.mainAudioStart();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Move Value
        h = GameManager.instance.isAction ? 0 : Input.GetAxisRaw("Horizontal") + right_Value + left_Value;
        v = GameManager.instance.isAction ? 0 : Input.GetAxisRaw("Vertical") + up_Value + down_Value;

        // Check Button Down & Up
        bool hDown = GameManager.instance.isAction ? false : Input.GetButtonDown("Horizontal") || right_down || left_down;
        bool vDown = GameManager.instance.isAction ? false : Input.GetButtonDown("Vertical") || up_down || down_down;
        bool hUp = GameManager.instance.isAction ? false : Input.GetButtonUp("Horizontal") || right_up || left_up;
        bool vUp = GameManager.instance.isAction ? false : Input.GetButtonUp("Vertical") || up_up || down_up;

        // Check Horizontal Move
        if (hDown)
        {
            isHorizonMove = true;
        }
        else if(vDown)
        {
            isHorizonMove = false;
        }
        else if(hUp || vUp)
        {
            isHorizonMove = h != 0;
        }

        // Animation
        if(anim.GetInteger("hAxisRaw") != h)
        {
            anim.SetBool("isChange", true);
            anim.SetInteger("hAxisRaw", (int)h);
        }
        else if(anim.GetInteger("vAxisRaw") != v)
        {
            anim.SetBool("isChange", true);
            anim.SetInteger("vAxisRaw", (int)v);
        }
        else
        {
            anim.SetBool("isChange", false);
        }

        // Direction
        if(vDown && v == 1)
        {
            dirVec = Vector3.up;
        }
        else if(vDown && v == -1)
        {
            dirVec = Vector3.down;
        }
        else if (hDown && h == -1)
        {
            dirVec = Vector3.left;
        }
        else if (hDown && h == 1)
        {
            dirVec = Vector3.right;
        }

        // Scan Object
        if (Input.GetButtonDown("Jump") && scanObject != null)
        {
            GameManager.instance.Action(scanObject);
        }
        else if (Input.GetMouseButtonDown(0) && scanObject != null && touchCheck == true)
        {
            GameManager.instance.Action(scanObject);
        }
        

        // Mobile Var Init
        up_down = false;
        down_down = false;
        left_down = false;
        right_down = false;
        up_up = false;
        down_up = false;
        left_up = false;
        right_up = false;



        // SceneMove
        if (rb2d.transform.position.x > 8.4)
        {
            DataMgr.instance.playerTp = new Vector3((rb2d.transform.position.x * -1) + 1, rb2d.transform.position.y);
            SceneManager.LoadScene(SceneNumber + 1);
        }
        else if(rb2d.transform.position.x < -8.4)
        {
            DataMgr.instance.playerTp = new Vector3((rb2d.transform.position.x * -1) - 1, rb2d.transform.position.y);
            SceneManager.LoadScene(SceneNumber - 1);
        }

        
    }

    private void FixedUpdate()
    {
        // Move
        Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rb2d.velocity = moveVec * Speed;

        // Ray
        Debug.DrawRay(rb2d.position, dirVec * 0.7f, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(rb2d.position, dirVec, 0.7f, LayerMask.GetMask("Object"));

        if(rayHit.collider != null)
        {
            scanObject = rayHit.collider.gameObject;
        }
        else
        {
            scanObject = null;
        }
    }

    public static void boolCheck()
    {
        touchCheck = false;
    }

    public static void ButtonDown(string type)
    {
        switch(type)
        {
            case "U":
                up_Value = 1;
                up_down = true;
                break;
            case "D":
                down_Value = -1;
                down_down = true;
                break;
            case "L":
                left_Value = -1;
                left_down = true;
                break;
            case "R":
                right_Value = 1;
                right_down = true;
                break;
            case "A":
                if(scanObject != null)
                {
                    touchCheck = true;
                    GameManager.instance.Action(scanObject);
                }
                break;
        }

    }
    public static void ButtonUp(string type)
    {
        switch (type)
        {
            case "U":
                up_Value = 0;
                up_up = true;
                //Debug.Log("u");
                break;
            case "D":
                down_Value = 0;
                down_up = true;
                //Debug.Log("d");
                break;
            case "L":
                left_Value = 0;
                left_up = true;
                //Debug.Log("l");
                break;
            case "R":
                right_Value = 0;
                right_up = true;
                //Debug.Log("r");
                break;
        }
    }
    
}
