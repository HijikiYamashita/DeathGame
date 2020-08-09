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
        PlayerController.sceneNameArray[2] = "03_TheHall_of_Virus";
        PlayerController.sceneNameArray[3] = "04_TheHall_of_Water";
        PlayerController.sceneNameArray[4] = "05_TheHall_of_Block";
        PlayerController.sceneNameArray[5] = "06_TheHall_of_VirusFire";
        PlayerController.sceneNameArray[6] = "07_TheHall_of_SilverBullet";
        PlayerController.sceneNameArray[7] = "08_TheHall_of_ThornBlock";
        PlayerController.sceneNameArray[8] = "09_TheHall_of_WaterFireThorn";
        PlayerController.sceneNameArray[9] = "10_TheHall_of_VirusBlock";
        PlayerController.sceneNameArray[10] = "11_TheHall_of_SecondThorn";
        PlayerController.sceneNameArray[11] = "12_TheHall_of_SecondFire";
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
