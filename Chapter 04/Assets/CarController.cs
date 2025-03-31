using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speedRatio = 0.01f;
    public float stopSpeed = 0.04f;
    public float decreaseRate = 0.98f;
    float speed = 0;
    Vector2 startPos;
    Vector2 endPos;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;

            speed = swipeLength * speedRatio;
            audio.Play();
        }
        speed *= decreaseRate;

        if(speed < stopSpeed)
        {
            speed = 0f;
        }

        transform.Translate(this.speed, 0, 0);
       
    }
}
