using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAudio : MonoBehaviour
{
    public static MainAudio instance;
    public AudioSource mainAudioSource;

    private void Awake()
    {
        //SceneNumber = SceneManager.GetActiveScene().buildIndex;
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    public void MusicDestroy()
    {
        mainAudioSource.Stop();
    }
}
