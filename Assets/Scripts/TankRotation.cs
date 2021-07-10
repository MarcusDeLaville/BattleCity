using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
public class TankRotation : MonoBehaviour
{
    [SerializeField] private Movement _movement;
    [SerializeField] private List<DirectionAngle> _directionAngles;
    
    private Vector2 _currentDirection;

    private void OnEnable()
    {
        _movement = GetComponent<Movement>();
    }

    private void FixedUpdate()
    {
        // if (_movement.MoveDirection.magnitude != 0)
        // {
            if (_movement.MoveDirection != _currentDirection)
            {
                Rotate(_movement.MoveDirection);
            }
        // }
    }

    private void Rotate(Vector2 direction)
    {
        _currentDirection = direction;
        
        for (int i = 0; i <= _directionAngles.Count - 1; i++)
        {
            if (direction == _directionAngles[i].Direction)
            {
                transform.rotation = TargetQuaternion(_directionAngles[i].Angle);
            }
        }
    }

    private Quaternion TargetQuaternion(float angle)
    {
        return Quaternion.Euler(0, 0, angle);
    }
    
    [Serializable]
    private struct DirectionAngle
    {
        public Vector2 Direction;
        public float Angle;
    }
}