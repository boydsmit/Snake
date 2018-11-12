using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartFollow : MonoBehaviour
{
    private GameObject _snakeHead;
    private PlayerMove _playerMove;
    private PlayerInput _input;
    
    private Rigidbody _rb;

    private void Start()
    {
        _snakeHead = GameObject.FindWithTag("Snake");
        _rb = gameObject.GetComponent<Rigidbody>();
        _input = _snakeHead.GetComponent<PlayerInput>();
        _playerMove = _snakeHead.GetComponent<PlayerMove>();
    }

    private void Update()
    {
        GetDir();
    }

    void Follow(float x, float y)
    {
        _rb.velocity = new Vector2(x, y).normalized * _playerMove.CurMoveSpd * Time.deltaTime;
    }
    
    void GetDir()
    {
        switch (_input.CurDir)
        {
            case PlayerInput.Dir.Up:
                Follow(0,1);
                break;
			
            case PlayerInput.Dir.Down:
                Follow(0,-1);
                break;
            case PlayerInput.Dir.Left:
                Follow(-1,0);
                break;
			
            case PlayerInput.Dir.Right:
                Follow(1,0);
                break;
        }
    }
}
    