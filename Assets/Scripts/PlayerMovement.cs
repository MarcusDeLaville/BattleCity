using UnityEngine;

public class PlayerMovement : Movement
{
    private void FixedUpdate()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        MoveDirection = new Vector2(inputHorizontal, inputVertical);
        
        Rigidbody.MovePosition(Rigidbody.position + MoveDirection * MoveSpeed * Time.fixedDeltaTime);
    }
}
