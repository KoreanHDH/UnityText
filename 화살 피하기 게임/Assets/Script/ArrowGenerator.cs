using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPreFab;
    public float span = 0.5f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(arrowPreFab);
            int px = Random.Range(-11,12);
            go.transform.position = new Vector3(px, 12, 0);
        }
    }
}
