using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text kanji;
    public Text hiragana;

    void Start()
    {
        
    }

    void Update()
    {
        if (PlayerController.death == 1)
        {
            kanji.text = "棘死";
            hiragana.text = "き  ょ  く  し";
        }
        if (PlayerController.death == 2)
        {
            kanji.text = "焼死";
            hiragana.text = "し  ょ  う  し";
        }
        if (PlayerController.death == 3)
        {
            kanji.text = "病死";
            hiragana.text = "び  ょ  う  し";
        }
        if (PlayerController.death == 4)
        {
            kanji.text = "溺死";
            hiragana.text = "で  き  し";
        }
        if (PlayerController.death == 5)
        {
            kanji.text = "安楽死";
            hiragana.text = "あ  ん  ら  く  し";
        }
        if (PlayerController.death == 6)
        {
            kanji.text = "落下死";
            hiragana.text = "ら  っ  か  し";
        }
        if (PlayerController.death == 7)
        {
            kanji.fontSize = 200;
            kanji.text = "ぎっくりご死";
            hiragana.text = "ぎ  っ  く  り  ご  し";
        }
    }

    public void retry()
    {
        SceneManager.LoadScene("TestStage");
    }
}
