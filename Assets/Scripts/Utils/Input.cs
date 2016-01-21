using UnityEngine;
using System.Collections;

public class Input : MonoBehaviour {

	//Movement var
	[SerializeField]private KeyCode _rightMoveKey;
	[SerializeField]private KeyCode _leftMoveKey;
	[SerializeField]private KeyCode _upMoveKey;
	[SerializeField]private KeyCode _downMoveKey;

	[SerializeField]private KeyCode _jumpKey;

	public delegate void IntDelegate(int value);
	public delegate void NormalDelegate();

	public event IntDelegate RightKeyPressed;
	public event NormalDelegate JumpKeyPressed;
	public event IntDelegate LeftKeyPressed;
	public event NormalDelegate MouseButtonPressed;
	public event NormalDelegate NoKeyPressed;

	private bool _keypressed = false;
	
	private void Update()
	{
		KeyPress ();
	}

	private void KeyPress()
	{

	}
}
