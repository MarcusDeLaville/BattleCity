using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] protected float MoveSpeed = 2f;
    
    protected Rigidbody2D Rigidbody;
    protected Vector2 MoveDirection;
    
    public Vector2 MovementDirection => MoveDirection;
    
    public virtual void OnEnable()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }
}
