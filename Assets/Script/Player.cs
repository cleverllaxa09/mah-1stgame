﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
[RequireComponent(typeof(Controller2D))]
public class Player : MonoBehaviour
{
    float moveSpeed = 6;
    float gravity = -20;
    Vector2 velocity;
    Controller2D controller;

    void Start()
    {
        controller = GetComponent<Controller2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        velocity.x = input.x * moveSpeed;
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
