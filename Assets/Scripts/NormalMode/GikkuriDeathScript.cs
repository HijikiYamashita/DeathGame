using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GikkuriDeathScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "moveBlock")
        {
            PlayerController.death = 7;
            SceneManager.LoadScene("GameOver");
        }
    }
}
