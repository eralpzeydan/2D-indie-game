using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 lastMoveDirection;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        HandlerMovement();
    }

    private void HandlerMovement(){
        float speed = 2f;
        float moveX = 0f;
        float moveY = 0f;

        animator.SetFloat("Horizontal",Input.GetAxis("Horizontal"));

        if(Input.GetKey(KeyCode.W)){
            moveY = +1f;
        }
        if(Input.GetKey(KeyCode.S)){
            moveY = -1f;
        }
        if(Input.GetKey(KeyCode.A)){
            moveX = -1f;
        }
        if(Input.GetKey(KeyCode.D)){
            moveX = +1f;
        }

        Vector3 moveDirection = new Vector3(moveX,moveY).normalized;
        transform.position += moveDirection*speed*Time.deltaTime;

    }
}
