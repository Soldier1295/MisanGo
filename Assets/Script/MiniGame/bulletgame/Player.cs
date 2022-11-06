using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    

    public float speed;
    public bool isTouchTop;
    public bool isTouchBottom;
    public bool isTouchLeft;
    public bool isTouchRight;
    public GameObject bulletA;
    public float maxShot;
    public float curShot;
    public int Hp;
    public float times;
    private float xAxis;

    public bool[] joyControl;
    public bool isControl;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        health();
    }


    void health()
    {
        if(Hp <= 0)
        {
            Debug.Log("Die");
            
            SceneManager.LoadScene("shooting");
            //»ç¸Á½Ã ¾À ¸®·Ñ
            
        }    
    }


    public void JoyPanel(int type)
    {
        for(int index=0; index < 9; index++)
        {
            joyControl[index] = index == type;
        }
    }

    public void JoyDown()
    {
        isControl = true;
    }

    public void Joyup()
    {
        isControl = false;
    }

    void Move()
    {
        

        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");
        
        if (joyControl[0]) { h = -1; v = 1; }
        if (joyControl[1]) { h = 0; v = 1; }
        if (joyControl[2]) { h = 1; v = 1; }
        if (joyControl[3]) { h = -1; v = 0; }
        if (joyControl[4]) { h = 0; v = 0; }

        if (joyControl[5]) { h = 1; v = 0; }
        if (joyControl[6]) { h = -1; v = -1; }
        if (joyControl[7]) { h = 0; v = -1; }
        if (joyControl[8]) { h = 1; v = -1; }
        


        if ((isTouchRight && h == 1) || (isTouchLeft && h == -1)|| !isControl)
            h = 0;
        
        if ((isTouchTop && v == 1) || (isTouchBottom && v == -1)|| !isControl)
            v = 0;
        
        Vector3 curPos = transform.position;
        Vector3 nextPos = new Vector3(h, v, 0) * speed * Time.deltaTime;


        transform.position = curPos + nextPos;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            switch(collision.gameObject.name)
            {
                case "Top":
                    isTouchTop = true;
                    break;
                case "Bottom":
                    isTouchBottom = true;
                    break;
                case "Left":
                    isTouchLeft = true;
                    break;
                case "Right":
                    isTouchRight =true;
                    break;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            switch (collision.gameObject.name)
            {
                case "Top":
                    isTouchTop = false;
                    break;
                case "Bottom":
                    isTouchBottom = false;
                    break;
                case "Left":
                    isTouchLeft = false;
                    break;
                case "Right":
                    isTouchRight = false;
                    break;
            }
        }
    }

    public void hit()
    {
        Debug.Log("fail");
        Hp -= 1;
    }

}
