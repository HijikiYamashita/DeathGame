using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    float soundTime = 1.0f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayerController.sceneNameArray[0] = "01_TheHall_of_Thorn";
        PlayerController.sceneNameArray[1] = "02_TheHall_of_Fire";
        PlayerController.sceneNameArray[2] = "TestStage";
    }

    void Update()
    {

    }

    public void gameStart()
    {
        audioSource.PlayOneShot(sound1);
        Invoke("sceanChange", 1.0f);
    }

    void sceanChange()
    {
        SceneManager.LoadScene("Menu");
    }
}
