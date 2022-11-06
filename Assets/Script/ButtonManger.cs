using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonManger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonDown(string type)
    {
        switch (type)
        {
            case "U":
                PlayerAction.ButtonDown("U");
                
                break;
            case "D":
                PlayerAction.ButtonDown("D");
                break;
            case "L":
                PlayerAction.ButtonDown("L");
                break;
            case "R":
                PlayerAction.ButtonDown("R");
                break;
            case "A":
                PlayerAction.ButtonDown("A");
                break;
        }

    }
    public void ButtonUp(string type)
    {
        switch (type)
        {
            case "U":
                PlayerAction.ButtonUp("U");
                break;
            case "D":
                PlayerAction.ButtonUp("D");
                break;
            case "L":
                PlayerAction.ButtonUp("L");
                break;
            case "R":
                PlayerAction.ButtonUp("R");
                break;
        }
    }

}
