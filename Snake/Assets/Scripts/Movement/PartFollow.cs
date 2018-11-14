using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartFollow : MonoBehaviour
{
    private GameObject _snakeHead;
    private PlayerMove _playerMove;
    private PlayerInput _input;
    private PlayerInput.Dir _dir;
    private bool _changeDir;
    private Vector3 _prevHeadLoc;
    

    private Rigidbody _rb;

    private void Start()
    {
        _snakeHead = GameObject.FindWithTag("Snake");
        _rb = gameObject.GetComponent<Rigidbody>();
        _input = _snakeHead.GetComponent<PlayerInput>();
        _playerMove = _snakeHead.GetComponent<PlayerMove>();    
        _dir = _input.CurDir;
    }

    private void Update()
    {
        ChangeDir();
        GetDir();
        if (_dir != _input.CurDir)
        {
            _changeDir = false;
        }
        
    }

    void Follow(float x, float y)
    {
            _rb.velocity = new Vector2(x, y).normalized * _playerMove.CurMoveSpd * Time.deltaTime;
    }

    void ChangeDir()
    {
        if (_changeDir == false)
        {
            _dir = _input.PrevDir;
            if (gameObject.transform.position == _snakeHead.transform.position)
            {
                _changeDir = true;
            }   
        }
        else
        {
            _dir = _input.CurDir;
        }
    }

    void Move(int x, int y)
    {
            Follow(x,y);
    }

    void GetDir()
    {
        switch (_dir)
        {
            case PlayerInput.Dir.Up:
                Move(0, 1);
                break;

            case PlayerInput.Dir.Down:
                Move(0, -1);
                break;
            case PlayerInput.Dir.Left:
                Move(-1, 0);
                break;
            case PlayerInput.Dir.Right:
                Move(1, 0);
                break;
        }
    }
}