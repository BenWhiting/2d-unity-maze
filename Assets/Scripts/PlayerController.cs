using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody2D playerRb;
    private Vector2 moveVelocity;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
       moveVelocity = moveInput.normalized * speed;
       playerRb.MovePosition(playerRb.position + moveVelocity * Time.fixedDeltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
    }
}