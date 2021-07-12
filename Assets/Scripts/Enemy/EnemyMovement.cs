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
        Rigidbody.MovePosition(Rigidbody.position + MoveDirection * MoveSpeed * Time.fixedDeltaTime);
    }

    private void ChangeDirection()
    {
        MoveDirection = _directions[Random.Range(0, _directions.Length)];
    }
}
