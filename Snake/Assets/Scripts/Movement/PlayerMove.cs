using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

	[SerializeField] private int _initialMoveSpd;
	private int _curMoveSpd;
	
	// Use this for initialization
	void Start ()
	{
		_curMoveSpd = _initialMoveSpd;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
	