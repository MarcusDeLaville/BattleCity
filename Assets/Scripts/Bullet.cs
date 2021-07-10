using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private LayerMask _interactionLayer;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent<Endurance>(out Endurance endurance))
        {
            if (((1 << other.gameObject.layer) & _interactionLayer) != 0)
            {
                endurance.TakeDamage(_damage);
            }
        }

        Destroy(gameObject);
    }
}
