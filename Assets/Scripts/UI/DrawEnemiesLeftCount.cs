using UnityEngine;

public class DrawEnemiesLeftCount : DrawCount
{
    [SerializeField] private EnemiesSpawner _enemiesSpawner;
    
    private void OnEnable()
    {
        _enemiesSpawner.EnemySpawned += Draw;
    }

    private void OnDisable()
    {
        _enemiesSpawner.EnemySpawned -= Draw;
    }
}
