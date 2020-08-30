using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Clear : MonoBehaviour
{
    GameObject SE;

    void Start()
    {
        SE = GameObject.Find("SE");
    }

    void Update()
    {
        
    }

    public void nextStage()
    {
        PlayerController.nextStage = Array.IndexOf(PlayerController.sceneNameArray, PlayerController.sceneName) + 1;
        PlayerPrefs.SetInt("stage", PlayerController.nextStage);
        PlayerPrefs.Save();
        SE.GetComponent<SE>().se();
        SceneManager.LoadScene(PlayerController.sceneNameArray[PlayerController.nextStage]);
    }

    public void quit()
    {
        PlayerController.nextStage = Array.IndexOf(PlayerController.sceneNameArray, PlayerController.sceneName) + 1;
        PlayerPrefs.SetInt("stage", PlayerController.nextStage);
        PlayerPrefs.Save();
        SE.GetComponent<SE>().se();
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}