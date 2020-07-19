using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public static int death = 0;

    public float time = 5.0f;

    public Text timeCount;

    int countDown = 0;

    void Start()
    {
        StageScroll.speed = 5.0f;
        moveSpeed = 5.0f;
        countDown = 0;
        timeCount.enabled = false;
        time = 5.0f;
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

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            StageScroll.speed -= 0.5f;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            StageScroll.speed += 0.5f;
        }

        if (countDown == 1)
        {
            timeCount.enabled = true;
            time -= Time.deltaTime;
            timeCount.text = "病死まであと" + time.ToString("N1") + "秒";
            if (time < 0f)
            {
                death = 3;
                SceneManager.LoadScene("GameOver");
            }
        }
        if (countDown == 2)
        {
            timeCount.enabled = true;
            time -= Time.deltaTime;
            timeCount.text = "注！強力な病気に感染した\n病死まであと" + time.ToString("N1") + "秒";
            if (time < 0f)
            {
                death = 3;
                SceneManager.LoadScene("GameOver");
            }
        }
        if (countDown == 3)
        {
            timeCount.enabled = true;
            time -= Time.deltaTime;
            timeCount.text = "溺死まであと" + time.ToString("N1") + "秒";
            if (time < 0f)
            {
                death = 4;
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "thorn")
        {
            death = 1;
            SceneManager.LoadScene("GameOver");
        }
        if (col.gameObject.tag == "fire")
        {
            death = 2;
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Virus1")
        {
            Destroy(col.gameObject);
            if (countDown == 0)
            {
                time = 5.0f;
                countDown = 1;
            }
        }
        if (col.gameObject.tag == "Virus2")
        {
            Destroy(col.gameObject);
            time = 3.0f;
            countDown = 2;
        }
        if (col.gameObject.tag == "silverBullet")
        {
            Destroy(col.gameObject);
            countDown = 0;
            timeCount.enabled = false;
            time = 5.0f;
        }
        if (col.gameObject.tag == "water")
        {
            StageScroll.speed = 3.0f;
            moveSpeed = 3.0f;
            time = 4.0f;
            countDown = 3;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "water")
        {
            StageScroll.speed = 5.0f;
            moveSpeed = 5.0f;
            countDown = 0;
            timeCount.enabled = false;
            time = 5.0f;
        }
    }
}
