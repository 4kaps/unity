using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    float jumpPower = 5f;
    float moveSpeed = 0.5f;
    Rigidbody rigid;

    void Awake(){
        rigid = GetComponent<Rigidbody>();
    }

    void Update(){
        Jump();
    }

    void FixedUpdate(){
        Move();
    }

    void Move(){
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rigid.AddForce(new Vector3(h*moveSpeed, 0, v*moveSpeed), ForceMode.Impulse);
    }

    void Jump(){
        if(Input.GetButtonDown("Jump")){
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }
}
