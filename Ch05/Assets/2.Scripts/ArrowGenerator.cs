using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float span = 1.0f;
    float delta = 0f;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-11, 10);
            go.transform.position = new Vector3(px, 7, 0);

            delta = 0;

            if (transform.position.y < -7f)
            {
                Destroy(gameObject);
            }

        }
    }
}
