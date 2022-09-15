using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UI;
using UnityEngine.Audio;
public class SceneScrip : MonoBehaviour
{

    public Text _score;
    void Start()
    {
        _score.text = PlayerPrefs.GetInt("Score") + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScenes");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void SetAudio(float value)
    {
        AudioListener.volume = value;
    }

    public void HomeButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}



