using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private int _speed = 10;
    private float _horizontal = 0f;
    private float _vertical = 0f;


    private void Update()
    {
        _horizontal += Input.GetAxis("Mouse X");
        _vertical -= Input.GetAxis("Mouse Y");
        RifleMoveWithMouse();
    }

    private void RifleMoveWithMouse()
    {
        if(_horizontal < 1)
        {
            _horizontal = 1;
        }
        else if(_horizontal > 8)
        {
            _horizontal = 8;
        }
        if (_vertical > 4)
        {
            _vertical = 4;
        }
        else if (_vertical <= -1)
        {
            _vertical = -1;
        }

        transform.eulerAngles = new Vector3(_vertical * _speed, _horizontal * _speed, 0.0f);
    }
}