using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float _forwardSpeed;

	[SerializeField] private float _horizontalSpeed;

	[SerializeField] private Rigidbody _rigidbody;
	[SerializeField] private float _jumpPower;
	
    private Vector3 _velocity = new Vector3();
	private float _maxHorizontalDistance = 4;


    private bool _isGrounded;

	private void Start()
	{
	}

	private void Update()
	{

		if (!GameInstance.Instance.IsGameStarted)
		{
          return;  
        }

        _velocity.z = _forwardSpeed;
		_velocity.y = _rigidbody.velocity.y;
		_velocity.x = Input.GetAxis("Horizontal") * _horizontalSpeed;
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
			Debug.Log("bastý");
            _velocity.y = _jumpPower;
            _isGrounded = false;
        }
    }

	private void FixedUpdate()
	{

		if(Mathf.Abs(_rigidbody.position.x) > _maxHorizontalDistance)
		{
			var clampedPozition = _rigidbody.position;
			clampedPozition.x = Mathf.Clamp(clampedPozition.x, -_maxHorizontalDistance, _maxHorizontalDistance);

			_rigidbody.position = clampedPozition;
			_velocity.x = 0;
		}
		_rigidbody.velocity = _velocity;


		Debug.DrawRay(transform.position, Vector3.down * 1.05f);
		_isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.05f);

    }

	
}