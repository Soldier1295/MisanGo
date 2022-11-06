using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizCheckBox : MonoBehaviour
{
    public static bool checkBox;
    public static bool checkBox2;
    Toggle m_goToggle;
    public string value;
    // Start is called before the first frame update
    void Start()
    {
        m_goToggle = GetComponent<Toggle>();
        value = this.gameObject.name;
    }

    public void ToggleClick(bool isOn)
    {
        if (isOn == true)
        {
            //value = this.gameObject.name;
            if (value == "No.2")
            {
                Debug.Log("ture");
                AnswerManager.instance.Quiz1 = true;


            }
            else
            {
                Debug.Log("false");
                AnswerManager.instance.Quiz1 = false;
            }
            checkBox = m_goToggle.isOn;

        }
    }

    public void AlToggleClick(bool isOn)
    {
        if (isOn == true)
        {
            //value = this.gameObject.name;
            if (value == "No.2")
            {
                Debug.Log("ture");
                Algorithms.instance.Quiz = true;


            }
            else
            {
                Debug.Log("false");
                Algorithms.instance.Quiz = false;
            }
            checkBox2 = m_goToggle.isOn;

        }
    }
}