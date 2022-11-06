using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndName : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = DataMgr.instance.nameSave;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
