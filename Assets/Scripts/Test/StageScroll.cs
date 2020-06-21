using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScroll : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        this.gameObject.transform.position += new Vector3(0, speed * Time.deltaTime,0);
    }
}
