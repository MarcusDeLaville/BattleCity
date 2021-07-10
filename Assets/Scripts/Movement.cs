using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] protected float _moveSpeed = 2f;
    
    protected Rigidbody2D _rigidbody;
    protected Vector2 _moveDirection;
    
    public Vector2 MoveDirection => _moveDirection;
    
    public virtual void OnEnable()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
