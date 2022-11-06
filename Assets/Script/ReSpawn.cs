using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReSpawn : MonoBehaviour
{
    public GameObject[] charPrefabs;
    public GameObject player;
    public int SceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        SceneNumber = SceneManager.GetActiveScene().buildIndex;
        if (DataMgr.instance.startCheck == false)
        {
            player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
            player.transform.position = transform.position;
            DataMgr.instance.startCheck = true;
        }
        else if(SceneNumber == 8 || SceneNumber == 9 || SceneNumber == 14 || SceneNumber == 15 || SceneNumber == 17)
        {
            player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
            player.transform.position = transform.position;
        }
        else if(SceneNumber == 4 && DataMgr.instance.AppSceneCheck == true)
        {
            player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
            player.transform.position = transform.position;
            DataMgr.instance.AppSceneCheck = false;
        }
        else if (SceneNumber == 7 && DataMgr.instance.Game2SceneCheck == true)
        {
            player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
            player.transform.position = transform.position;
            DataMgr.instance.Game2SceneCheck = false;
        }
        else if (SceneNumber == 6 && DataMgr.instance.ClassRoomCheck == true)
        {
            player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
            player.transform.position = transform.position;
            DataMgr.instance.ClassRoomCheck = false;
        }
        else if(SceneNumber == 9 && DataMgr.instance.FindDfImg == true)
        {
            player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
            player.transform.position = transform.position;
            DataMgr.instance.FindDfImg = false;
        }
        else if (SceneNumber == 9 && DataMgr.instance.shooting == true)
        {
            player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
            player.transform.position = transform.position;
            DataMgr.instance.shooting = false;
        }
        else if (SceneNumber == 15 && DataMgr.instance.flappyBird == true)
        {
            player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
            player.transform.position = transform.position;
            DataMgr.instance.flappyBird = false;
        }
        else if (SceneNumber == 17 && DataMgr.instance.EnglishGame == true)
        {
            player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
            player.transform.position = transform.position;
            DataMgr.instance.EnglishGame = false;
        }
        else if (SceneNumber == 5 && DataMgr.instance.CardGame == true)
        {
            player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
            player.transform.position = transform.position;
            DataMgr.instance.CardGame = false;
        }
        else
        {
            player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
            player.transform.position = DataMgr.instance.playerTp;
        }

    }

}
