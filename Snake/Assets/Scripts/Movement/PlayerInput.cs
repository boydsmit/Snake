using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.WSA;

public class PlayerInput : MonoBehaviour {

	public enum Dir  {None,Left,Right,Up,Down}

	public Dir CurDir;
	public Dir PrevDir;
	public Dir Buffer;
	
	void Update () 
	{
		GetKey();
	}

	void GetKey()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
			CurDir = Dir.Left;
			BufferKey();
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			
			CurDir = Dir.Up;
			BufferKey();
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			CurDir = Dir.Right;
			BufferKey();
		}

		if (Input.GetKeyDown(KeyCode.S))
		{
			CurDir = Dir.Down;
			BufferKey();
		}
	}

	private bool CheckEmpty(Dir var)
	{
		if (var == Dir.None) return true;

		return false;
	}

	private void BufferKey()
	{
		if (CheckEmpty(PrevDir))
		{
			PrevDir = CurDir;
			Buffer = PrevDir;
		}
		else
		{
			PrevDir = Buffer;
			Buffer = CurDir;
		}
	}
}
