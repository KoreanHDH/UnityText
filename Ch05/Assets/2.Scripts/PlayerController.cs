using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    GameObject player;
    GameObject background;
    public float moveStep = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        this.player = GameObject.Find("player");
        this.background = GameObject.Find("background");
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-moveStep,0,0);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(moveStep,0,0);
        }
        
    }

    public void LButtonDown()
    {
        transform.Translate(-moveStep, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(moveStep, 0, 0);
    }

}
