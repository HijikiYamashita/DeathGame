using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "thorn")
        {
            Debug.Log("棘死");
            SceneManager.LoadScene("ThornDeath");
        }
        if (col.gameObject.tag == "fire")
        {
            Debug.Log("焼死");
            SceneManager.LoadScene("BurnedDeath");
        }
        if (col.gameObject.tag == "virus")
        {
            Debug.Log("病死");
            SceneManager.LoadScene("DiseasesDeath");
        }
    }
}
