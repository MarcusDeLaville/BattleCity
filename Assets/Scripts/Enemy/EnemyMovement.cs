using UnityEngine;

public class EnemyMovement : Movement
{
    [SerializeField] private EnemyNavigation _enemyNavigation;
    
    [SerializeField] private Vector2[] _directions;

    public override void OnEnable()
    {
        _enemyNavigation.WayBlock += ChangeDirection;
        base.OnEnable();
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _moveDirection * _moveSpeed * Time.fixedDeltaTime);
    }

    private void ChangeDirection()
    {
        _moveDirection = _directions[Random.Range(0, _directions.Length)];
    }
}
