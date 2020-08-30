using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class BackToTitle : MonoBehaviour
{
    GameObject SE;

    void Start()
    {
        SE = GameObject.Find("SE");
    }

    void Update()
    {
        
    }

    public void buttonPush()
    {
        if (PlayerController.sceneName == "ForeverStage")
        {
            if (PlayerPrefs.GetFloat("foreverTimeHistry") <= PlayerController.foreverTime)
            {
                PlayerPrefs.SetFloat("foreverTimeHistry", PlayerController.foreverTime);
            }
            else if (PlayerPrefs.GetFloat("foreverTimeHistry") == null)
            {
                PlayerPrefs.SetFloat("foreverTimeHistry", PlayerController.foreverTime);
            }
        }
        else if (SceneManager.GetActiveScene().name == "GameOver")
        {
            PlayerController.nextStage = Array.IndexOf(PlayerController.sceneNameArray, PlayerController.sceneName);
            PlayerPrefs.SetInt("stage", PlayerController.nextStage);
            PlayerPrefs.Save();
        }
        else if (SceneManager.GetActiveScene().name == "Clear")
        {
            PlayerController.nextStage = Array.IndexOf(PlayerController.sceneNameArray, PlayerController.sceneName) + 1;
            PlayerPrefs.SetInt("stage", PlayerController.nextStage);
            PlayerPrefs.Save();
        }
        else
        {
        }
        SE.GetComponent<SE>().se();
        SceneManager.LoadScene("Title");
    }
}
