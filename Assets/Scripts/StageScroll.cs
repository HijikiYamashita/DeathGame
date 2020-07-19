using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScroll : MonoBehaviour
{
    public static float speed = 5.0f;
  
    void Start()
    {
        
    }

    void Update()
    {
        this.gameObject.transform.position += new Vector3(0, speed * Time.deltaTime,0);
    }
}
