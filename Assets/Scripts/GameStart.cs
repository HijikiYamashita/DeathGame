using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStart : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        
    }

    public void newGameStart()
    {
        SceneManager.LoadScene("01_TheHall_of_Thorn");
    }

    public void continueStart()
    {
        
    }

}
