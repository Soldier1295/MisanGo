using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class nameInput : MonoBehaviour
{
    public TMP_InputField nameIn;
    private string nameData = null;
    // Start is called before the first frame update
    void Start()
    {
        nameData = nameIn.GetComponent<TMP_InputField>().text;
    }

    public void nameCheck()
    {
        nameData = nameIn.text;

        DataMgr.instance.nameSave = nameData;
    }
}
