using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource mainAudioSource;
    public AudioSource questClearAudioSource;
    public AudioSource missionAudioSource;
    public AudioSource doorOpenAudioSource;
    public AudioSource shoutAudioSource;
    public AudioSource creditAudioSource;

    public bool check;

    // Start is called before the first frame update
    public static AudioManager instance;
    private void Awake()
    {
        
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
    void Start()
    {
        
    }

    // Update is called once per frame
    public void mainAudioStart()
    {
        mainAudioSource.Play();
    }
    public void mainAudioStop()
    {
        mainAudioSource.Stop();
    }

    public void questClearAuidoStart()
    {
        questClearAudioSource.Play();
    }

    public void missionBackgroundAudioStart()
    {
        missionAudioSource.Play();
    }
    public void missionBackgroundAudioStop()
    {
        missionAudioSource.Stop();
    }
    public void doorOpenAudioStart()
    {
        doorOpenAudioSource.Play();
    }

    public void shoutAudioStart()
    {
        shoutAudioSource.Play();
    }
    public void creditAudioStart()
    {
        creditAudioSource.Play();
    }
}
