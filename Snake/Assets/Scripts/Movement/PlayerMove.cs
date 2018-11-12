using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

	[SerializeField] private int _initialMoveSpd;
	public int CurMoveSpd;
	private Rigidbody _rb;

	private PlayerInput _input;
	
	// Use this for initialization
	void Start ()
	{
		_rb = gameObject.GetComponent<Rigidbody>();
		CurMoveSpd = _initialMoveSpd;
		_input = gameObject.GetComponent<PlayerInput>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetDir();			
	}

	void Move(float x, float y)
	{
		_rb.velocity = new Vector2(x, y).normalized * CurMoveSpd * Time.deltaTime;
	}

	void GetDir()
	{
		switch (_input.CurDir)
		{
			case PlayerInput.Dir.Up:
				Move(0,1);
				break;
			
			case PlayerInput.Dir.Down:
				Move(0,-1);
				break;
			case PlayerInput.Dir.Left:
				Move(-1,0);
				break;
			
			case PlayerInput.Dir.Right:
				Move(1,0);
				break;
		}
	}

}
	