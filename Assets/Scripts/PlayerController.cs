using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody playerRigidBody;
    void Start()
    {
        playerRigidBody = GetComponent<playerRigidBody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Use the input values to move the player
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        playerRigidBody.AddForce(movement * speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

    