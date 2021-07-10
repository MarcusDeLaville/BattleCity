using UnityEngine;

public class PlayerMovement : Movement
{
    private void FixedUpdate()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        _moveDirection = new Vector2(inputHorizontal, inputVertical);
        
        _rigidbody.MovePosition(_rigidbody.position + _moveDirection * _moveSpeed * Time.fixedDeltaTime);
    }
}
