using System;
using UnityEngine;

public class Endurance : MonoBehaviour
{
    [SerializeField] private int _enduranceCount = 100;
    public event Action Destroyed;

    public void TakeDamage(int damage)
    {
        if(damage <= 0)
            throw new ArgumentOutOfRangeException();

        _enduranceCount -= damage;
        
        TryDestroyed();
    }

    private void TryDestroyed()
    {
        if (_enduranceCount <= 0)
        {
            Destroyed?.Invoke();
            Destroy(gameObject);
        }
    }
}
