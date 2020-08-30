using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class GameStart : MonoBehaviour
{
    GameObject SE;

    void Start()
    {
        SE = GameObject.Find("SE");
    }

    void Update()
    {
        
    }

    public void normalMode()
    {
        SE.GetComponent<SE>().se();
        SceneManager.LoadScene("NormalMode");
    }

    public void foreverMode()
    {
        SE.GetComponent<SE>().se();
        SceneManager.LoadScene("ForeverMode");
    }

    public void foreverHistry()
    {
        SE.GetComponent<SE>().se();
        SceneManager.LoadScene("ForeverHistry");
    }

    public void foreverStart()
    {
        SE.GetComponent<SE>().se();
        SceneManager.LoadScene("ForeverStage");
    }

    public void newGameStart()
    {
        SE.GetComponent<SE>().se();
        SceneManager.LoadScene("01_TheHall_of_Thorn");
    }

    public void continueStart()
    {
        SE.GetComponent<SE>().se();
        PlayerController.nextStage = PlayerPrefs.GetInt("stage");
        SceneManager.LoadScene(PlayerController.sceneNameArray[PlayerController.nextStage]);
    }

}
