using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class checkInput : MonoBehaviour
{
    public TMP_InputField answerInput;
    public GameObject ALetterOfAdmission;
    public GameObject creadit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void answerCheck()
    {
        ALetterOfAdmission.SetActive(false);
        creadit.SetActive(true);
        AudioManager.instance.creditAudioStart();

    }
}
