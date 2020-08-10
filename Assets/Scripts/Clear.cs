using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Clear : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void nextStage()
    {
        PlayerController.nextStage = Array.IndexOf(PlayerController.sceneNameArray, PlayerController.sceneName) + 1;
        SceneManager.LoadScene(PlayerController.sceneNameArray[PlayerController.nextStage]);
    }

    public void quit()
    {
        PlayerController.nextStage = Array.IndexOf(PlayerController.sceneNameArray, PlayerController.sceneName) + 1;
        PlayerPrefs.SetInt("stage", PlayerController.nextStage);
        PlayerPrefs.Save();
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}