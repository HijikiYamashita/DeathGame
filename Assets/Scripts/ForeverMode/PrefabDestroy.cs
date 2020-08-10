using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDestroy : MonoBehaviour
{
    GameObject prefab;

    void Start()
    {
        prefab = this.gameObject;
    }

    void Update()
    {
        if (transform.GetChild(0).gameObject.transform.position.y >= 11)
        {
            Destroy(prefab);
        }
    }
}
