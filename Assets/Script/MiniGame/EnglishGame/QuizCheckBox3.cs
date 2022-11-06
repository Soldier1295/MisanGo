using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizCheckBox3 : MonoBehaviour
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
            if (value == "No.4")
            {
                Debug.Log("ture");
                AnswerManager.instance.Quiz3 = true;

            }
            else
            {
                Debug.Log("false");
                AnswerManager.instance.Quiz3 = false;

            }
            checkBox = m_goToggle.isOn;

        }
    }
}
