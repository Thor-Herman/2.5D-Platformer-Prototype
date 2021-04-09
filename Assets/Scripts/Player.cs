﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController _controller;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _gravity = 1.0f, _jumpHeight = 15.0f;
    private float _yVelocity;
    private bool _canDoubleJump;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizonalInput = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizonalInput, 0, 0);
        Vector3 velocity = direction * _speed;

        if (_controller.isGrounded) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                _yVelocity = _jumpHeight;
                _canDoubleJump = true;
            }
        }
        else {
            if (Input.GetKeyDown(KeyCode.Space) && _canDoubleJump) {
                _yVelocity = _jumpHeight;
                _canDoubleJump = false;
            }
            else _yVelocity -= _gravity;
        }
        velocity.y = _yVelocity;

        _controller.Move(velocity * Time.deltaTime);
    }
}
