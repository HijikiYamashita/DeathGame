using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoeverGameOver : MonoBehaviour
{
    public Text kanji;
    public Text hiragana;

    void Start()
    {
        
    }

    void Update()
    {
        if (ForeverPlayerController.death == 1)
        {
            kanji.text = "棘死";
            hiragana.text = "き  ょ  く  し";
        }
        if (ForeverPlayerController.death == 2)
        {
            kanji.text = "焼死";
            hiragana.text = "し  ょ  う  し";
        }
        if (ForeverPlayerController.death == 3)
        {
            kanji.text = "病死";
            hiragana.text = "び  ょ  う  し";
        }
        if (ForeverPlayerController.death == 4)
        {
            kanji.text = "溺死";
            hiragana.text = "で  き  し";
        }
        if (ForeverPlayerController.death == 5)
        {
            kanji.text = "安楽死";
            hiragana.text = "あ  ん  ら  く  し";
        }
        if (ForeverPlayerController.death == 6)
        {
            kanji.text = "落下死";
            hiragana.text = "ら  っ  か  し";
        }
        if (ForeverPlayerController.death == 7)
        {
            kanji.fontSize = 200;
            kanji.text = "ぎっくりご死";
            hiragana.text = "ぎ  っ  く  り  ご  し";
        }
        if (ForeverPlayerController.death == 8)
        {
            kanji.text = "薬剤死";
            hiragana.text = "や  く  ざ  い  し";
        }
    }

    public void retry()
    {
        if (PlayerPrefs.GetFloat("foreverTimeHistry") <= ForeverPlayerController.foreverTime)
        {
            PlayerPrefs.SetFloat("foreverTimeHistry", ForeverPlayerController.foreverTime);
        }
        else if (PlayerPrefs.GetFloat("foreverTimeHistry") == null)
        {
            PlayerPrefs.SetFloat("foreverTimeHistry", ForeverPlayerController.foreverTime);
        }
        SceneManager.LoadScene("ForeverStage");
    }

    public void quit()
    {
        if (PlayerPrefs.GetFloat("foreverTimeHistry") <= ForeverPlayerController.foreverTime)
        {
            PlayerPrefs.SetFloat("foreverTimeHistry", ForeverPlayerController.foreverTime);
        }
        else if (PlayerPrefs.GetFloat("foreverTimeHistry") == null)
        {
            PlayerPrefs.SetFloat("foreverTimeHistry", ForeverPlayerController.foreverTime);
        }
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
