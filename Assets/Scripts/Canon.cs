using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _bulletPrefab;
    [SerializeField] private Transform _shootPosition;
    [SerializeField] private float _shootDelay = 1.5f;

    private void Start()
    {
        StartCoroutine(ShootLoop());
    }

    private IEnumerator ShootLoop()
    {
        while (gameObject != null)
        {
            yield return  new WaitForSeconds(_shootDelay);
            Shoot();
        }
    }
    
    private void Shoot()
    {
        Rigidbody2D bullet = Instantiate(_bulletPrefab, _shootPosition.position, quaternion.identity);
        bullet.AddForce(transform.TransformDirection(Vector2.right) * 5, ForceMode2D.Impulse);
    }
}
