using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.WSA;

public class PlayerInput : MonoBehaviour {

	public enum Dir  {Left,Right,Up,Down}

	public Dir CurDir;
	
	// Update is called once per frame
	void Update () 
	{
		GetKey();
	}

	void GetKey()
	{
		if(Input.GetKey(KeyCode.A))
		{
			CurDir = Dir.Left;
		}

		if (Input.GetKey(KeyCode.W))
		{
			CurDir = Dir.Up;
		}

		if (Input.GetKey(KeyCode.D))
		{
			CurDir = Dir.Right;
		}

		if (Input.GetKey(KeyCode.S))
		{
			CurDir = Dir.Down;
		}
	}

	
}
