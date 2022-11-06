using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckBox : MonoBehaviour
{
    public Character character;
    public static bool checkBox;
    Toggle m_goToggle;

    // Start is called before the first frame update
    void Start()
    {
        m_goToggle = GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleClick(bool isOn)
    {
        if(isOn == true)
        {
            DataMgr.instance.currentCharacter = character;
            checkBox = m_goToggle.isOn;
        }
        
    }
}
