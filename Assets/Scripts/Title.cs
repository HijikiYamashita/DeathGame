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
    }

    void Update()
    {

    }

    public void gameStart()
    {
        audioSource.PlayOneShot(sound1);
        Invoke("sceanChange", 3.0f);
    }

    void sceanChange()
    {
        SceneManager.LoadScene("TestStage");
    }
}
