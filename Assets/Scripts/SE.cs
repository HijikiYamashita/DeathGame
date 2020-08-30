using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SE : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Title");
    }

   void Update()
    {
        
    }

    public void se()
    {
        audioSource.PlayOneShot(sound1);
    }
}
