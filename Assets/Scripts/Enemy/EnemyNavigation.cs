using System;
using UnityEngine;

public class EnemyNavigation : MonoBehaviour
{
    [SerializeField] private float _lengthRay = 1f;
    [SerializeField] private LayerMask _navigationLayer;
    
    [SerializeField] private bool _wayBlocked;

    public event Action WayBlock;

    private void FixedUpdate()
    {
        Navigation();
    }

    private void Navigation()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), _lengthRay, _navigationLayer);

        _wayBlocked = hit;

        if (_wayBlocked == true)
        {
            DrawNavigationRay(hit.distance, Color.green);
            WayBlock?.Invoke();
        }
        else
        {
            DrawNavigationRay(hit.distance, Color.red);
        }
    }

    private void DrawNavigationRay(float hitDistance, Color color)
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.right), color, hitDistance);
    }
    
}
