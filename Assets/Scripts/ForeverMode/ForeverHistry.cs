using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForeverHistry : MonoBehaviour
{

    Text histry;
    public GameObject histryObj;

    void Start()
    {
        histry = histryObj.GetComponent<Text>();
        histry.text = "最大記録\n" + PlayerPrefs.GetFloat("foreverTimeHistry").ToString("N1") + "秒";
    }

    void Update()
    {
        
    }
}
