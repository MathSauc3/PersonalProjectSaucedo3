using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	public Rigidbody PlayerBody;
	private Vector3 PlayerMovementInput;

	public float Speed;
	public float JumpForce;

	private void Update()
	{
		PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
		movePlayer();
	}

	private void movePlayer()
	{
		Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
		PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z);

		if(Input.GetKeyDown(KeyCode.Space))
		{
			PlayerBody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
		}
	}

	private void MovePlayerCamera()
	{

	}
}
