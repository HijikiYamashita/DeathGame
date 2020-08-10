using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCreate : MonoBehaviour
{
    int stagePrefab;
    bool count = true;
    public int random;

    public GameObject[] stageSets;

    void Start()
    {

    }

    void Update()
    {
        if (Mathf.RoundToInt(this.gameObject.transform.position.y) % 10 == 0)
        {
            if (count == true)
            {
                stageRandomCreate();
                count = false;
            }
             else if (count == false)
            {
                StartCoroutine("countTrue");
            }
        }

    }

    void stageRandomCreate()
    {
        stagePrefab = Random.Range(1, random);
        Instantiate(stageSets[stagePrefab], new Vector3(0.0f, -10.0f, 0.0f), Quaternion.identity);
    }

    IEnumerator countTrue()
    {
        yield return new WaitForSeconds(0.5f);
        count = true;
    }
}
