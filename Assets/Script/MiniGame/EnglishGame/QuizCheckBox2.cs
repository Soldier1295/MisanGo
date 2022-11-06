using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizCheckBox2 : MonoBehaviour
{
    public static bool checkBox;
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
            if (value == "No.1")
            {
                Debug.Log("ture");
                AnswerManager.instance.Quiz2 = true;

            }
            else
            {
                Debug.Log("false");
                AnswerManager.instance.Quiz2 = false;

            }
            checkBox = m_goToggle.isOn;

        }
    }
}
