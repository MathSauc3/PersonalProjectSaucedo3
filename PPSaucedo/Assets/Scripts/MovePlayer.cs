using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	private Vector2 PlayerMouseInput;
	public Transform PlayerCamera;
	public Rigidbody PlayerBody;
	private Vector3 PlayerMovementInput;
	private float xRot;
	private float yRot;

	public float Speed;
	public float JumpForce;
	public float Sensitivity;

	private void start()
	{

	}


	private void Update()
	{
		PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
		PlayerMouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
		movePlayer();
		MovePlayerCamera();
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
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
		xRot -= PlayerMouseInput.y * Sensitivity;
		xRot = Mathf.Clamp(xRot, -90f, 90f);
		transform.Rotate(0f, PlayerMouseInput.x *Sensitivity, 0f);
		PlayerCamera.transform.localRotation = Quaternion.Euler (xRot, 0f, 0f);


	}
}
