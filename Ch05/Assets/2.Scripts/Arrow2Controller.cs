using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow2Controller : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
