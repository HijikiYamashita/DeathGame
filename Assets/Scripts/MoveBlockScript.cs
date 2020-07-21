using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockScript : MonoBehaviour
{
    public static float speed = 5.0f;
    bool playerCol = false;

    void Start()
    {

    }

    void Update()
    {
        if (playerCol == false)
        {
            this.gameObject.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerCol = true;
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerCol = false;
        }
    }
}
