using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGetScript : MonoBehaviour
{
    public float itemNumber;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (itemNumber == 1)
            {
                Debug.Log("Umbrella");
            }
        }
    }
}