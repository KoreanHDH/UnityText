using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float JumpForce = 200.0f;
    public float WalkForce = 10.0f;
    public float MaxWalkSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 점프
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.JumpForce);
        }

        // 좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        
        // 플레이어 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // 속도 제한
        if (speedx < this.MaxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * WalkForce);
        }

        // 방향 반전
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }
}
